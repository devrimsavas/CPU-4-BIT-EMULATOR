using System;
using System.IO;

namespace WinFormsApp1.Models
{
    public static class DebugLogger
    {
        private static string _logPath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            $"debug_{DateTime.Now:yyyyMMdd_HHmmss}.txt"
        );

        public static void Log(string message)
        {
            File.AppendAllText(_logPath, message + Environment.NewLine);
        }

        public static void Clear()
        {
            if (File.Exists(_logPath))
                File.Delete(_logPath);
        }

        public static string LogPath => _logPath;
    }
}