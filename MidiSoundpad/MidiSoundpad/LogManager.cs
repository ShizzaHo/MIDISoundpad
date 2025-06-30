using System;
using System.Collections.Generic;
using System;

namespace MidiSoundpad
{
    internal class LogManager
    {
        private static readonly LogManager instance = new LogManager();

        private LogManager()
        {
        }

        public static LogManager Instance
        {
            get
            {
                return instance;
            }
        }

        private List<string> log = new List<string>();
        private Action callback;

        public void RegistrationCallback(Action logCallback)
        {
            callback = logCallback;
        }

        public void AddLog(string prefix, string logText)
        {
            string message = $"{GetFormattedDateTime()} [{prefix}] {logText}";
            log.Add(message);

            callback?.Invoke();
        }

        public string GetLog()
        {
            return string.Join(Environment.NewLine, log);
        }

        private string GetFormattedDateTime()
        {
            DateTime now = DateTime.Now;
            return $"[{now:HH:mm:ss dd.MM.yyyy}]";
        }
    }
}