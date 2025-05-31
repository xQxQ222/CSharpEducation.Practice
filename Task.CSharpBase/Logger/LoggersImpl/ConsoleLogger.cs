using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.LoggersImpl
{
    class ConsoleLogger : ILogger
    {
        public void Debug(string message)
        {
            Log(message, LogLevel.DEBUG);
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

        public void Log(string message, LogLevel logLevel)
        {
            Console.WriteLine($"{DateTime.Now.ToString()} {this.GetType().Name}| {logLevel.ToString()} | {message}\n");
        }

        public void Trace(string message)
        {
            Log(message, LogLevel.TRACE);
        }

        public void Warn(string message)
        {
            Log(message, LogLevel.WARN);
        }
    }
}
