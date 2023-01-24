using System;
using System.IO;
namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    [TestMethod]
    public void LogTest()
    {
        string       path         = @"../../../../MyTest.txt";
        FileLogger   logger       = new FileLogger(path);
        DateTime     date         = DateTime.Now;
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        logger.Log(LogLevel.Error, "Test message");
        StreamReader sr = File.OpenText(path);

        Assert.AreEqual($"{date} FileLogger Error: Test message", sr.ReadLine());
        sr.Close();
    }
}
