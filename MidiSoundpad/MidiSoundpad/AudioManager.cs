using System;
using System.Collections.Generic;
using NAudio.CoreAudioApi;
using NAudio.Wave.SampleProviders;
using NAudio.Wave;
using IniParser.Model;
using IniParser;
using System.IO;
using System.Windows.Forms;

namespace MidiSoundpad
{
    internal class AudioManager : IDisposable
    {
        public ConfigManager _configManager;

        private WasapiCapture waveIn;
        private BufferedWaveProvider microphoneBuffer;
        private AudioFileReader backgroundMusic;
        private MixingSampleProvider mixer;
        private WasapiOut waveOut;
        private MMDevice selectedOutput;

        private List<string> microphoneNames = new List<string>();
        private MMDeviceEnumerator deviceEnumerator = new MMDeviceEnumerator();

        private readonly object mixerLock = new object();
        private readonly List<ISampleProvider> activeSources = new List<ISampleProvider>();

        public AudioManager()
        {
            LogManager.Instance.AddLog("AUDIOManager", $"Initializing audio devices");

            var parser = new FileIniDataParser();
            string userDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string settingsPath = Path.Combine(userDirectory, "MidiSoundpad", "settings.ini");

            IniData data = parser.ReadFile(settingsPath);

            SelectMicrophone(data["Audio"]["Input"]);
            SelectOutput(data["Audio"]["Output"]);
        }

        public void Dispose()
        {
            waveIn?.Dispose();
            waveOut?.Dispose();
            backgroundMusic?.Dispose();
        }

        public List<string> GetMicrophoneList()
        {
            var recordingDevices = deviceEnumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            microphoneNames.Clear();

            foreach (var device in recordingDevices)
            {
                microphoneNames.Add(device.FriendlyName);
            }

            return microphoneNames;
        }

        public List<string> GetOutputList()
        {
            var outputDevices = deviceEnumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
            var deviceNames = new List<string>();
            foreach (var device in outputDevices)
            {
                deviceNames.Add(device.FriendlyName);
            }
            return deviceNames;
        }

        public void SelectOutput(string name)
        {
            var outputDevices = deviceEnumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
            selectedOutput = null;

            foreach (var device in outputDevices)
            {
                if (device.FriendlyName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    selectedOutput = device;
                    break;
                }
            }

            LogManager.Instance.AddLog("AUDIOManager", $"Output device is selected: {selectedOutput.FriendlyName}");
        }

        public void SelectMicrophone(string name)
        {
            var recordingDevices = deviceEnumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            MMDevice selectedDevice = null;

            foreach (var device in recordingDevices)
            {
                if (device.FriendlyName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    selectedDevice = device;
                    break;
                }
            }

            waveIn = new WasapiCapture(selectedDevice);
            waveIn.DataAvailable += OnDataAvailable;
            waveIn.RecordingStopped += OnRecordingStopped;

            LogManager.Instance.AddLog("AUDIOManager", $"Input device is selected: {name}");

        }

        public void Start()
        {
            microphoneBuffer = new BufferedWaveProvider(waveIn.WaveFormat)
            {
                DiscardOnBufferOverflow = true
            };


            var micSampleProvider = microphoneBuffer.ToSampleProvider();

            mixer = new MixingSampleProvider(WaveFormat.CreateIeeeFloatWaveFormat(
                waveIn.WaveFormat.SampleRate, waveIn.WaveFormat.Channels))
            {
                ReadFully = true
            };

            mixer.AddMixerInput(micSampleProvider);

            waveOut = new WasapiOut(selectedOutput, AudioClientShareMode.Shared, true, Int32.Parse(_configManager.GetParamValue(_configManager.settingsPath, "Audio", "WasapiLatency")));
            waveOut.Init(mixer);

            waveIn.StartRecording();
            waveOut.Play();

            LogManager.Instance.AddLog("AUDIOManager", $"Real-time recording started");
        }

        public void Stop()
        {
            waveIn?.StopRecording();
            waveOut?.Stop();
            LogManager.Instance.AddLog("AUDIOManager", $"Capture and playback are stopped.");
        }

        private void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            microphoneBuffer.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }

        private void OnRecordingStopped(object sender, StoppedEventArgs e)
        {
            LogManager.Instance.AddLog("AUDIOManager", $"Audio capture has been stopped.");
        }

        public void PlayAudioInOutput(string filePath, int volume, bool multiple)
        {
            if (!multiple)
            {
                lock (mixerLock)
                {
                    foreach (var source in activeSources)
                    {
                        mixer.RemoveMixerInput(source);

                        if (source is IDisposable disposable)
                        {
                            disposable.Dispose();
                        }
                    }
                    activeSources.Clear();
                }

                backgroundMusic?.Dispose();
                backgroundMusic = null;
            }

            backgroundMusic = new AudioFileReader(filePath);
            var musicProvider = backgroundMusic.ToSampleProvider();

            var volumeProvider = new VolumeSampleProvider(musicProvider)
            {
                Volume = volume / 100f
            };

            ISampleProvider convertedProvider = volumeProvider;

            if (musicProvider.WaveFormat.SampleRate != mixer.WaveFormat.SampleRate)
            {
                convertedProvider = new WdlResamplingSampleProvider(convertedProvider, mixer.WaveFormat.SampleRate);
            }

            if (musicProvider.WaveFormat.Channels != mixer.WaveFormat.Channels)
            {
                if (mixer.WaveFormat.Channels == 1 && convertedProvider.WaveFormat.Channels == 2)
                {
                    convertedProvider = new StereoToMonoSampleProvider(convertedProvider);
                }
                else if (mixer.WaveFormat.Channels == 2 && convertedProvider.WaveFormat.Channels == 1)
                {
                    convertedProvider = new MonoToStereoSampleProvider(convertedProvider);
                }
            }

            lock (mixerLock)
            {
                mixer.AddMixerInput(convertedProvider);
                activeSources.Add(convertedProvider);
            }

            if (waveOut == null)
            {
                waveOut = new WasapiOut(selectedOutput, AudioClientShareMode.Shared, true, 100);
                waveOut.Init(mixer);
                waveOut.Play();
            }
        }
    }
}