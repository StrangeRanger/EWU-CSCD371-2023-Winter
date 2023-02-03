namespace Logger.Tests;

public class TestLogger : BaseLogger, ILogger
{
    public TestLogger(string logSource) => LogSource = logSource;
    
    public List<(LogLevel LogLevel, string Message)> LoggedTestMessages { get; } = new List<(LogLevel, string)>();

    public static ILogger CreateLogger(in TestLoggerConfiguration configuration) => 
        new TestLogger(configuration.LogSource);

    static ILogger ILogger.CreateLogger(in ILoggerConfiguration configuration) => 
        configuration is TestLoggerConfiguration testLoggerConfiguration
            ? CreateLogger(testLoggerConfiguration)
            : throw new ArgumentException("Invalid configuration type", nameof(configuration));

    public override void Log(LogLevel logLevel, string message) => LoggedTestMessages.Add((logLevel, message));
    public override string LogSource { get; }
}

public class TestLoggerConfiguration : BaseLoggerConfiguration, ILoggerConfiguration
{
    public TestLoggerConfiguration(string logSource) : base(logSource) { }

}
