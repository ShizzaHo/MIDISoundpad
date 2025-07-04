﻿using IniParser;
using IniParser.Model;
using Microsoft.Win32;
using MidiSoundpad.Properties;
using NAudio.CoreAudioApi;
using NAudio.Midi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MidiSoundpad
{
    public partial class Form1 : Form
    {
        /*=== MODULES ===*/
        private MidiManager midiManager;
        private AudioManager audioManager;
        private ConfigManager configManager;
        /*=== MODULES ===*/

        //The application is ready to work
        bool isAppReady = false;

        //Variables for the binds editing mode
        private string editableBindName = "";
        private int editableBindIndex = 0;
        private string audioPathTemp = "";

        public Form1()
        {
            InitializeComponent();

            ConfigManager TEMPconfigManager = new ConfigManager();

            if (Boolean.Parse(TEMPconfigManager.GetParamValue(TEMPconfigManager.settingsPath, "General", "AutorunTray")))
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            } else
            {
                notifyIcon1.Visible = false;
            }

            ApplicationInit();
        }
        public void ApplicationInit()
        {
            LogManager.Instance.RegistrationCallback(LogWriter);

            LogManager.Instance.AddLog("MAIN", $"Initialization of the program has begun");

            LoadProgramModules();
            UpdateBindsList();

            midiManager.ListenMidiKey();

            isAppReady = true;

            audioManager.SelectOutput(configManager.GetParamValue(configManager.settingsPath, "Audio", "SoundPadMonitoringOutput"));

            //launchTray.Checked = Convert.ToBoolean(configManager.GetParamValue(configManager.settingsPath, "Audio", "Midi"));

            MidiControllerBox.Text = configManager.GetParamValue(configManager.settingsPath, "Audio", "Midi");
            MicrophoneBox.Text = configManager.GetParamValue(configManager.settingsPath, "Audio", "Input");
            VirtualCableBox.Text = configManager.GetParamValue(configManager.settingsPath, "Audio", "Output");

            spMonitoringOutput.Text = configManager.GetParamValue(configManager.settingsPath, "Audio", "SoundPadMonitoringOutput");
            spMonitoringMode.Checked = Boolean.Parse(configManager.GetParamValue(configManager.settingsPath, "Audio", "SoundPadMonitoringMode"));
            monitoringVolumeFactor.Value = Int32.Parse(configManager.GetParamValue(configManager.settingsPath, "Audio", "SoundPadMonitoringVolumeFactor"));

            VirtualCableBox.Text = configManager.GetParamValue(configManager.settingsPath, "Audio", "Output");
            wasapiLatency.Value = Int32.Parse(configManager.GetParamValue(configManager.settingsPath, "Audio", "WasapiLatency"));



            launchTray.Checked = Boolean.Parse(configManager.GetParamValue(configManager.settingsPath, "General", "AutorunTray"));
            autorun.Checked = Boolean.Parse(configManager.GetParamValue(configManager.settingsPath, "General", "Autorun"));
            trayMode.Checked = Boolean.Parse(configManager.GetParamValue(configManager.settingsPath, "General", "TrayMode"));


            LogManager.Instance.AddLog("MAIN", $"The program is successfully ready to work");
        }

        private void LoadProgramModules()
        {
            configManager = new ConfigManager();
            midiManager = new MidiManager();
            audioManager = new AudioManager();

            LoadMidiControllers();
            LoadMicrophones();
            LoadOutputs();

            midiManager._configManager = configManager;
            midiManager._audioManager = audioManager;

            audioManager._configManager = configManager;
        }

        private void LogWriter()
        {
            log.Text = LogManager.Instance.GetLog();
        }

        private void LoadMidiControllers()
        {
            string[] controllers = midiManager.GetMidiControllers();

            MidiControllerBox.Items.Clear();

            if (controllers.Length > 0)
            {
                MidiControllerBox.Items.AddRange(controllers);
                MidiControllerBox.SelectedIndex = 0;
            }
            else
            {
                MidiControllerBox.Items.Add("No MIDI controllers found");
                MidiControllerBox.Enabled = false;
            }
        }

        private void LoadMicrophones()
        {
            List<string> microphones = audioManager.GetMicrophoneList();

            MicrophoneBox.Items.Clear();

            if (microphones.Count > 0)
            {
                MicrophoneBox.Items.AddRange(microphones.ToArray());
                MicrophoneBox.SelectedIndex = 0;
            }
            else
            {
                MicrophoneBox.Items.Add("Input devices not found");
                MicrophoneBox.Enabled = false;
            }
        }

        private void LoadOutputs()
        {
            List<string> outputs = audioManager.GetOutputList();

            VirtualCableBox.Items.Clear();

            if (outputs.Count > 0)
            {
                VirtualCableBox.Items.AddRange(outputs.ToArray());
                VirtualCableBox.SelectedIndex = 0;

                spMonitoringOutput.Items.AddRange(outputs.ToArray());
            }
            else
            {
                VirtualCableBox.Items.Add("Output devices not found");
                VirtualCableBox.Enabled = false;
            }
        }

        private void MidiControllerBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(!isAppReady) { return; }

            string selectedControllerName = MidiControllerBox.SelectedItem?.ToString();

            midiManager.SelectMidiController(selectedControllerName);
            configManager.ChangeAndSaveParam(configManager.settingsPath, "Audio", "Midi", selectedControllerName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void MicrophoneBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!isAppReady) { return; }

            string selectedMicrophoneName = MicrophoneBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedMicrophoneName))
            {
                return;
            }

            audioManager.Stop();
            audioManager.SelectMicrophone(selectedMicrophoneName);
            audioManager.Start();

            configManager.ChangeAndSaveParam(configManager.settingsPath, "Audio", "Input", selectedMicrophoneName);
        }

        private void VirtualCableBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isAppReady) { return; }

            string selectedOutputName = VirtualCableBox.SelectedItem?.ToString();

            audioManager.Stop();
            audioManager.SelectOutput(selectedOutputName);
            audioManager.Start();

            configManager.ChangeAndSaveParam(configManager.settingsPath, "Audio", "Output", selectedOutputName);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string bindName = GenerateBindName();

            configManager.ChangeAndSaveParam(configManager.bindsPath, bindName, "name", "newBind_" + bindName);
            configManager.ChangeAndSaveParam(configManager.bindsPath, bindName, "midiKey", "0");
            configManager.ChangeAndSaveParam(configManager.bindsPath, bindName, "action", "sound");
            configManager.ChangeAndSaveParam(configManager.bindsPath, bindName, "sound_audiofile", "");
            configManager.ChangeAndSaveParam(configManager.bindsPath, bindName, "sound_volume", "100");
            configManager.ChangeAndSaveParam(configManager.bindsPath, bindName, "sound_multiple", "false");

            UpdateBindsList();
            bindsList.SelectedIndex = bindsList.Items.Count - 1;
        }

        public static string GenerateBindName()
        {
            Random random = new Random();
            DateTime now = DateTime.Now;
            string timeFormatted = now.ToString("HH:mm");
            string dateFormatted = now.ToString("dd.MM");
            int randomNumber = random.Next(0, 10000);

            return $"{timeFormatted}_{dateFormatted}_{randomNumber}";
        }

        public void UpdateBindsList()
        {
            bindsList.Items.Clear();

            foreach(string bindName in configManager.GetAllSections(configManager.bindsPath))
            {
                bindsList.Items.Add(configManager.GetParamValue(configManager.bindsPath, bindName, "name"));
            }
        }

        public void LoadBindEditData(string key)
        {
            editableBindName = key;
            editableBindIndex = bindsList.SelectedIndex;

            bindName.Text = configManager.GetParamValue(configManager.bindsPath, key, "name"); ;
            bindMidiKey.Text = configManager.GetParamValue(configManager.bindsPath, key, "midiKey");

            bindVolume.Value = Int32.Parse(configManager.GetParamValue(configManager.bindsPath, key, "sound_volume"));
            bindMultiple.Checked = Convert.ToBoolean(configManager.GetParamValue(configManager.bindsPath, key, "sound_multiple"));

            switch (configManager.GetParamValue(configManager.bindsPath, key, "action"))
            {
                case "sound":
                    radioSound.Checked = true;
                    break;
                case "effect":
                    radioEffect.Checked = true;
                    break;
                case "macro":
                    radioMacro.Checked = true;
                    break;
            }

            soundSelected.Text = $"Selected sound: {Path.GetFileName(configManager.GetParamValue(configManager.bindsPath, key, "sound_audiofile"))}";
        }

        private void bindsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            audioPathTemp = null;

            LoadBindEditData(configManager.GetSectionThroughIndex(configManager.bindsPath, bindsList.SelectedIndex));
        }

        private void bindDelete_Click(object sender, EventArgs e)
        {
            configManager.DeleteSection(configManager.bindsPath, editableBindName);
            UpdateBindsList();
            editableBindName = "";
        }

        private void bindSave_Click(object sender, EventArgs e)
        {
            configManager.ChangeAndSaveParam(configManager.bindsPath, editableBindName, "name", bindName.Text);
            configManager.ChangeAndSaveParam(configManager.bindsPath, editableBindName, "midiKey", bindMidiKey.Text);
            
            if(radioSound.Checked)
            {
                configManager.ChangeAndSaveParam(configManager.bindsPath, editableBindName, "action", "sound");

                if (audioPathTemp != null) configManager.ChangeAndSaveParam(configManager.bindsPath, editableBindName, "sound_audiofile", audioPathTemp);

                configManager.ChangeAndSaveParam(configManager.bindsPath, editableBindName, "sound_volume", bindVolume.Value.ToString());
                configManager.ChangeAndSaveParam(configManager.bindsPath, editableBindName, "sound_multiple", bindMultiple.Checked.ToString());
            }

            UpdateBindsList();
            bindsList.SelectedIndex = editableBindIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            midiKeyWaitText.Visible = true;

            midiManager.waitPressMidiKey = true;
            midiManager.midiWaitCallback = WaitMidiKeyForBind;
        }

        private void WaitMidiKeyForBind(int note)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<int>(WaitMidiKeyForBind), new object[] { note });
                return;
            }

            bindMidiKey.Value = note;
            midiKeyWaitText.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = null;
            openFileDialog1.Filter = "*.mp3;*.wav;*.ogg;*.flac;*.m4a)|*.mp3;*.wav;*.ogg;*.flac;*.m4a|MP3 (*.mp3)|*.mp3|WAV (*.wav)|*.wav";
            openFileDialog1.Title = "Select an audio file";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog1.FileName;
                string fileName = Path.GetFileName(sourceFilePath);
                string destinationFilePath = Path.Combine(configManager.soundsLibraryPath, fileName);
                File.Copy(sourceFilePath, destinationFilePath, true);

                audioPathTemp = sourceFilePath;
                soundSelected.Text = $"Selected sound: {Path.GetFileName(sourceFilePath)}";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = configManager.soundsLibraryPath;
            openFileDialog1.Filter = "*.mp3;*.wav;*.ogg;*.flac;*.m4a)|*.mp3;*.wav;*.ogg;*.flac;*.m4a|MP3 (*.mp3)|*.mp3|WAV (*.wav)|*.wav";
            openFileDialog1.Title = "Select an audio file";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog1.FileName;
                string fileName = Path.GetFileName(sourceFilePath);
                string destinationFilePath = Path.Combine(configManager.soundsLibraryPath, fileName);

                audioPathTemp = sourceFilePath;
                soundSelected.Text = $"Selected sound: {Path.GetFileName(sourceFilePath)}";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", configManager.soundsLibraryPath);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            configManager.ChangeAndSaveParam(configManager.settingsPath, "Audio", "WasapiLatency", wasapiLatency.Value.ToString());

            configManager.ChangeAndSaveParam(configManager.settingsPath, "Audio", "SoundPadMonitoringMode", spMonitoringMode.Checked.ToString());
            configManager.ChangeAndSaveParam(configManager.settingsPath, "Audio", "SoundPadMonitoringOutput", spMonitoringOutput.SelectedItem.ToString());
            configManager.ChangeAndSaveParam(configManager.settingsPath, "Audio", "SoundPadMonitoringVolumeFactor", monitoringVolumeFactor.Value.ToString());

            var result = MessageBox.Show(
                "To apply the new settings, you need to restart the program.\n\nRestart now?",
                "A restart is required",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Restart();

                Environment.Exit(0);
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ShizzaHo/MIDISoundpad");
        }

        private void label19_Click(object sender, EventArgs e)
        {
            Process.Start("https://vb-audio.com/Cable/");
        }

        private void label20_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.donationalerts.com/r/shizzaho");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowWindow()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Activate();

            notifyIcon1.Visible = false;
        }

        private void HideWindow()
        {
            this.ShowInTaskbar = false;
            this.Hide();

            notifyIcon1.Visible = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if(Boolean.Parse(configManager.GetParamValue(configManager.settingsPath, "General", "TrayMode")))
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                    HideWindow();
                }
                else
                {
                    base.OnFormClosing(e);
                }
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
            else if (e.Button == MouseButtons.Left)
            {
                ShowWindow();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            configManager.ChangeAndSaveParam(configManager.settingsPath, "General", "TrayMode", trayMode.Checked.ToString());
        }

        private void autorun_CheckedChanged(object sender, EventArgs e)
        {
            configManager.ChangeAndSaveParam(configManager.settingsPath, "General", "Autorun", autorun.Checked.ToString());
            AutoRunToggle(autorun.Checked);
        }

        private void launchTray_CheckedChanged(object sender, EventArgs e)
        {
            configManager.ChangeAndSaveParam(configManager.settingsPath, "General", "AutorunTray", launchTray.Checked.ToString());
        }

        public void AutoRunToggle(bool status)
        {
            string appName = "MyAppName"; // название, под которым будет записан ключ
            string appPath = Application.ExecutablePath; // путь к исполняемому файлу

            RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

            if (status)
            {
                rk.SetValue(appName, "\"" + appPath + "\"");
            }
            else
            {
                if (rk.GetValue(appName) != null)
                    rk.DeleteValue(appName);
            }
        }
    }
}
