using IniParser.Model;
using IniParser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.CoreAudioApi;
using NAudio.Midi;
using System.Windows.Forms;

namespace MidiSoundpad
{
    internal class ConfigManager
    {
        public FileIniDataParser parser;

        public string userDirectory;
        public string soundsLibraryPath;
        public string midiSoundpadPath;
        public string bindsPath;
        public string settingsPath;

        public ConfigManager()
        {
            LogManager.Instance.AddLog("CONFIGManager", $"Initializing program settings");

            parser = new FileIniDataParser();

            userDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            midiSoundpadPath = Path.Combine(userDirectory, "MidiSoundpad");
            soundsLibraryPath = Path.Combine(midiSoundpadPath, "soundsLibrary");
            bindsPath = Path.Combine(midiSoundpadPath, "binds.ini");
            settingsPath = Path.Combine(midiSoundpadPath, "settings.ini");

            ConfigInit();
        }

        public void ConfigInit()
        {
            if (Directory.Exists(midiSoundpadPath) == false)
            {
                Directory.CreateDirectory(midiSoundpadPath);
                LogManager.Instance.AddLog("CONFIGManager", $"The directory for the program has been successfully created along the way: {midiSoundpadPath}");
            }

            if (Directory.Exists(soundsLibraryPath) == false)
            {
                Directory.CreateDirectory(soundsLibraryPath);
                LogManager.Instance.AddLog("CONFIGManager", $"The audio library directory has been successfully created");
            }

            if (File.Exists(settingsPath) == false)
            {
                var parser = new FileIniDataParser();
                MMDeviceEnumerator deviceEnumerator = new MMDeviceEnumerator();

                var iniData = new IniData();
                iniData["General"]["Autorun"] = "false";
                iniData["General"]["AutorunTray"] = "false";
                iniData["General"]["TrayMode"] = "false";

                iniData["Audio"]["Midi"] = MidiIn.DeviceInfo(0).ProductName;
                iniData["Audio"]["Input"] = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Console).FriendlyName;
                iniData["Audio"]["Output"] = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console).FriendlyName;
                iniData["Audio"]["WasapiLatency"] = "30";

                parser.WriteFile(settingsPath, iniData);

                LogManager.Instance.AddLog("CONFIGManager", $"The settings file has been created");
            }

            if (File.Exists(bindsPath) == false)
            {
                var parser = new FileIniDataParser();
                MMDeviceEnumerator deviceEnumerator = new MMDeviceEnumerator();

                var iniData = new IniData();

                parser.WriteFile(bindsPath, iniData);

                LogManager.Instance.AddLog("CONFIGManager", $"An empty binds file has been created");
            }
        }

        public void ChangeAndSaveParam(string path, string section, string key, string value)
        {
            IniData data = parser.ReadFile(path);

            data[section][key] = value;

            parser.WriteFile(path, data);
        }
        public string GetParamValue(string path, string section, string key)
        {
            IniData data = parser.ReadFile(path);

            return data[section][key];
        }

        public string[] GetAllSections(string path)
        {
            if (!File.Exists(path))
            {
                LogManager.Instance.AddLog("CONFIGManager", $"The file at path {path} does not exist.");
                return Array.Empty<string>();
            }

            IniData data = parser.ReadFile(path);
            var sections = data.Sections.Select(s => s.SectionName).ToArray();

            return sections;
        }

        public void DeleteSection(string path, string section)
        {
            if (!File.Exists(path))
            {
                LogManager.Instance.AddLog("CONFIGManager", $"The binds file was not found");
                return;
            }

            IniData data = parser.ReadFile(path);

            if (data.Sections.ContainsSection(section))
            {
                data.Sections.RemoveSection(section);
                parser.WriteFile(path, data);
            }
        }

        public string GetSectionThroughIndex(string path, int index)
        {
            IniData data = parser.ReadFile(path);
            var sections = data.Sections;

            if (index < 0 || index >= sections.Count)
            {
                return null;
            }

            return sections.ElementAt(index).SectionName;
        }
    }
}
