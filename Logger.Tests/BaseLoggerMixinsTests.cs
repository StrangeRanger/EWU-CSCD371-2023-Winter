﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Logger.Tests;

[TestClass]
public class BaseLoggerMixinsTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Error_WithNullLogger_ThrowsException()
    {
        BaseLoggerMixins.Error(null!, "");
    }

    [TestMethod]
    public void Error_WithData_LogsMessage()
    {
        // Arrange
        var logger = new TestLogger(nameof(BaseLoggerMixinsTests));

        // Act
        logger.Error("Message 42");

        // Assert
        Assert.AreEqual(1, logger.LoggedTestMessages.Count);
        Assert.AreEqual(LogLevel.Error, logger.LoggedTestMessages[0].LogLevel);
        Assert.AreEqual("Message 42", logger.LoggedTestMessages[0].Message);
    }

}

/*public partial class TestLogger : BaseLogger
{
    public TestLogger(string logSource)
    {
        LogSource=logSource;
    }
    public List<(LogLevel LogLevel, string Message)> LoggedMessages { get; } = new List<(LogLevel, string)>();

    public override string LogSource { get; }


    public override void Log(LogLevel logLevel, string message)
    {
        LoggedMessages.Add((logLevel, message));
    }
}*/