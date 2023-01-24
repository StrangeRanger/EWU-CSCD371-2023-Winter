namespace Logger;

public class LogFactory
{
    private string    _filePath;
    public BaseLogger CreateLogger(string className)
    {
        if (_filePath is null) { return null; }
        return className.Equals(nameof(FileLogger)) ? new FileLogger(_filePath) : null;
    }

    public void ConfigureFileLogger(string filePath)
    {
        _filePath = filePath;
    }
}
