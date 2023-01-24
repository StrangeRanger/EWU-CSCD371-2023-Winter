using System;
using System.IO;
namespace Logger;

public class FileLogger : BaseLogger
{
    // Question: What is the purpose are the auto property? Should it always be public or is
    //           it ok to make it private.
    private string FilePath { get; set; }
    
    public FileLogger(string filePath)
    {
        FilePath = filePath;
    }

    public override void Log(LogLevel logLevel, string message)
    {
        DateTime date = DateTime.Now;
        ClassName     = nameof(FileLogger);
        string outGoing =
                $"{date} {ClassName} {Enum.GetName(typeof(LogLevel), logLevel)}: {message}";

        StreamWriter streamWriter = File.CreateText(FilePath);
        streamWriter.WriteLine(outGoing);
        streamWriter.Close();
    }
}
