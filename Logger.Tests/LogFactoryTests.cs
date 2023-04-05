namespace Logger.Tests;

[TestClass]
public class LogFactoryTests
{
    [TestMethod]
    public void CreateLogger_Configured_ReturnsNotNull()
    {
        LogFactory logFactory = new();
        logFactory.ConfigureFileLogger("TestPath");
        BaseLogger? baseLogger = logFactory.CreateLogger(nameof(LogFactoryTests));
        Assert.IsNotNull(baseLogger);
    }

    [TestMethod]
    public void CreateLoggerTest_ReturnsNull()
    {
        LogFactory logFactory = new();
        BaseLogger? baseLogger = logFactory.CreateLogger(nameof(FileLogger));
        Assert.AreEqual(null, baseLogger);
    }
}
