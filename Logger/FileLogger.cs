namespace Logger;

public class FileLogger : BaseLogger, ILogger
{
    public FileLogger(string logSource, string filePath) : base(logSource)
    {
        LogSource = logSource;
        File = new FileInfo(filePath);
    }
    private FileInfo File { get; }

    public string FilePath { get => File.FullName; }

    //public FileLogger(string logSource, string filePath) : base(logSource) => File = new FileInfo(filePath);

    //public FileLogger(FileLoggerConfiguration configuration) : this(configuration.LogSource, configuration.FilePath) {}

    //public static FileLogger CreateLogger(FileLoggerConfiguration configuration) => new(configuration);

    public override void Log(LogLevel logLevel, string message)
    {
        using StreamWriter writer = File.AppendText();
        writer.WriteLine($"{ DateTime.Now },{LogSource},{logLevel},{message}");
    }

    public static ILogger CreateLogger(in ILoggerConfiguration configuration)
    {
        if (configuration is FileLoggerConfiguration fileLoggerConfiguration)
        {
            return new FileLogger(fileLoggerConfiguration.LogSource, fileLoggerConfiguration.FilePath);
        }
        else
        {
            throw new ArgumentException("Invalid configuration type", nameof(configuration));
        }
    }

    public override string LogSource { get; }
}
