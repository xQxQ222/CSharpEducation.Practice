﻿namespace Logger
{
    public interface ILogger
    {
        void Trace(string message);
        void Info(string message);
        void Debug(string message);
        void Warn(string message);
        void Error(string message);
        void Fatal(string message);

        void Log(string message, LogLevel logLevel);
    }
}
