namespace Logger;

public class LogFactory
{
    private string    _filePath;
    public BaseLogger CreateLogger(string className)
    {
        if (_filePath is null) { return null; }
        return new FileLogger(_filePath) { ClassName = className };
    }

    public void ConfigureFileLogger(string filePath)
    {
        _filePath = filePath;
    }
}
