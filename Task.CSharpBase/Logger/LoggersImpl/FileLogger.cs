using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Logger.LoggersImpl
{
    public class FileLogger : ILogger
    {

        private string _filePath = @"B:\logs\" + DateTime.Now.Date.ToString("dd/MM/yyyy") +".txt";

        private void CheckFileExists()
        {
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }
        }

        public void Error(string message)
        {
            Log(message, LogLevel.ERROR);
        }

        public void Fatal(string message)
        {
            Log(message, LogLevel.FATAL);
        }

        public void Info(string message)
        {
            Log(message, LogLevel.INFO);
        }

        public void Trace(string message)
        {
            Log(message, LogLevel.TRACE);
        }

        public void Warn(string message)
        {
            Log(message,LogLevel.WARN);
        }

        public void Debug(string message)
        {
            Log(message, LogLevel.DEBUG);
        }

        public void Log(string message, LogLevel logLevel)
        {
            CheckFileExists();
            File.AppendAllText(_filePath, $"{DateTime.Now.ToString()} {this.GetType().Name}| {logLevel.ToString()} | {message}\n");
        }
    }
}
