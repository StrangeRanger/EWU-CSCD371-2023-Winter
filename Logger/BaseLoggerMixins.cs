using System;
namespace Logger;

public static class BaseLoggerMixins
{
    public static void Error(this BaseLogger? baseLogger, string message, params object[] args)
    {
        if (baseLogger is null) { throw new ArgumentNullException(); }

        LogLevel logLevel = LogLevel.Error;
        baseLogger.Log(logLevel, string.Format(message, args));
    }

    public static void Warning(this BaseLogger? baseLogger, string message, params object[] args)
    {
        if (baseLogger is null) { throw new ArgumentNullException(); }

        LogLevel logLevel = LogLevel.Warning;
        baseLogger.Log(logLevel, string.Format(message, args));
    }

    public static void Information(this BaseLogger? baseLogger, string message,
                                   params object[] args)
    {
        if (baseLogger is null) { throw new ArgumentNullException(); }

        LogLevel logLevel = LogLevel.Information;
        baseLogger.Log(logLevel, string.Format(message, args));
    }

    public static void Debug(this BaseLogger? baseLogger, string message, params object[] args)
    {
        if (baseLogger is null) { throw new ArgumentNullException(); }

        LogLevel logLevel = LogLevel.Debug;
        baseLogger.Log(logLevel, string.Format(message, args));
    }
}
