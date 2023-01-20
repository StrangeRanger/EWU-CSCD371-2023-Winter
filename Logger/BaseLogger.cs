namespace Logger {
public abstract class BaseLogger {
    protected string ClassName { get; set; }
    public abstract void Log(LogLevel logLevel, string message);
}
}
