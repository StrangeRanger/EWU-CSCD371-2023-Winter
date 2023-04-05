using System;
using System.IO;
namespace Logger;

public class FileLogger : BaseLogger
{
    private string _FilePath;

    public FileLogger(string filePath, string className)
    {
        ClassName = className;
        _FilePath = filePath;
    }

    public override void Log(LogLevel logLevel, string message)
    {
        DateTime date = DateTime.Now;
        string outGoing = $"{date} {ClassName} {logLevel}: {message}";

        StreamWriter streamWriter = File.CreateText(_FilePath);
        streamWriter.WriteLine(outGoing);
        streamWriter.Close();
    }
}
