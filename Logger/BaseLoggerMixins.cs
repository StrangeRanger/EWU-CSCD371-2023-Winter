using System;
namespace Logger;

public static class BaseLoggerMixins
{
    public static void Error(this BaseLogger logger, string message, params object[] args)
    {
        if (logger is null) { throw new ArgumentNullException(); }

        LogLevel logLevel = LogLevel.Error;
        logger.Log(logLevel, string.Format(message, args));
    }

    public static void Warning(this BaseLogger logger, string message, params object[] args)
    {
        if (logger is null) { throw new ArgumentNullException(); }

        LogLevel logLevel = LogLevel.Warning;
        logger.Log(logLevel, string.Format(message, args));
    }

    public static void Information(this BaseLogger logger, string message,
                                   params object[] args)
    {
        if (logger is null) { throw new ArgumentNullException(); }

        LogLevel logLevel = LogLevel.Information;
        logger.Log(logLevel, string.Format(message, args));
    }

    public static void Debug(this BaseLogger logger, string message, params object[] args)
    {
        if (logger is null) { throw new ArgumentNullException(); }

        LogLevel logLevel = LogLevel.Debug;
        logger.Log(logLevel, string.Format(message, args));
    }
}
