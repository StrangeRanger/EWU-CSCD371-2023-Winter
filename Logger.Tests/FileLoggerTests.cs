using System;
using System.IO;
namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    [TestMethod]
    public void LogTest_TestMessage_AreEqual()
    {
        string path = Path.GetTempFileName();
        FileLogger logger = new FileLogger(path, nameof(FileLoggerTests));
        DateTime date = DateTime.Now;
        String className = nameof(FileLoggerTests);
        StringWriter stringWriter = new();

        Console.SetOut(stringWriter);
        logger.Log(LogLevel.Error, "Test message");
        StreamReader sr = File.OpenText(path);

        Assert.AreEqual($"{date} {className} Error: Test message", sr.ReadLine());
        sr.Close();
        File.Delete(path);
    }
}
