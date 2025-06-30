using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;
using NAudio.Midi;
using NAudio.Wave;

namespace MidiSoundpad
{
    internal class MidiManager
    {
        public ConfigManager _configManager;
        public AudioManager _audioManager;

        public Action<int> midiWaitCallback;
        public bool waitPressMidiKey = false;

        private int selectedMidiController;
        private MidiIn midiIn;

        private byte? pressedNote = null;
        private ManualResetEvent midiKeyPressWaitHandle = new ManualResetEvent(false);

        public MidiManager()
        {
            LogManager.Instance.AddLog("MIDIManager", $"Initializing midi devices");

            var parser = new FileIniDataParser();
            string userDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string settingsPath = Path.Combine(userDirectory, "MidiSoundpad", "settings.ini");

            IniData data = parser.ReadFile(settingsPath);

            SelectMidiController(data["Audio"]["Midi"]);
        }

        public string[] GetMidiControllers()
        {
            int deviceCount = MidiIn.NumberOfDevices;

            if (deviceCount == 0)
            {
                return Array.Empty<string>();
            }

            var deviceNames = new List<string>();

            for (int i = 0; i < deviceCount; i++)
            {
                var deviceInfo = MidiIn.DeviceInfo(i);
                deviceNames.Add(deviceInfo.ProductName);
            }

            LogManager.Instance.AddLog("MIDIManager", $"Found {deviceCount} midi devices");

            return deviceNames.ToArray();
        }

        public void SelectMidiController(string midiName)
        {
            int deviceCount = MidiIn.NumberOfDevices;
            bool found = false;

            for (int i = 0; i < deviceCount; i++)
            {
                var deviceInfo = MidiIn.DeviceInfo(i);

                if (deviceInfo.ProductName.Equals(midiName, StringComparison.OrdinalIgnoreCase))
                {
                    selectedMidiController = i;
                    found = true;
                    LogManager.Instance.AddLog("MIDIManager", $"A midi listening device has been selected: {midiName} ({i})");
                    break;
                }
            }
        }

        public void ListenMidiKey()
        {
            if (selectedMidiController < 0 || selectedMidiController >= MidiIn.NumberOfDevices)
            {
                MessageBox.Show("The MIDI controller is not selected or unavailable.\n\nRestart the program and connect any MIDI device first");
                Application.Exit();
                return;
            }

            midiIn = new MidiIn(selectedMidiController);
            midiIn.MessageReceived += OnMidiMessageReceived;
            midiIn.Start();
        }

        private void OnMidiMessageReceived(object sender, MidiInMessageEventArgs e)
        {
            byte command = (byte)(e.RawMessage & 0xF0);
            byte note = (byte)((e.RawMessage >> 8) & 0xFF);
            byte velocity = (byte)((e.RawMessage >> 16) & 0xFF);

            switch (command)
            {
                case 0x90: // Note On
                    if (velocity > 0)
                    {
                        if (waitPressMidiKey)
                        {
                            midiWaitCallback(note);
                            waitPressMidiKey = false;
                            return;
                        }

                        foreach (string bindName in _configManager.GetAllSections(_configManager.bindsPath))
                        {
                            if (_configManager.GetParamValue(_configManager.bindsPath, bindName, "midiKey") == note.ToString())
                            {
                                _audioManager.PlayAudioInOutput(_configManager.GetParamValue(_configManager.bindsPath, bindName, "sound_audiofile"), Int32.Parse(_configManager.GetParamValue(_configManager.bindsPath, bindName, "sound_volume")), Convert.ToBoolean(_configManager.GetParamValue(_configManager.bindsPath, bindName, "sound_multiple")));
                            }
                        }
                    }
                    else
                    {
                        // If velocity == 0, this is equivalent to Note Off
                    }
                    break;

                case 0x80: // Note Off
                    // Logic for handling key release
                    break;
            }
        }

        public void SubscribeMidiKey(byte note)
        {
            MessageBox.Show(note.ToString());
        }

        public void UnistenMidiKey()
        {
            if (midiIn != null)
            {
                midiIn.Stop();
                midiIn.Dispose();
                midiIn = null;
            }
        }
    }
}