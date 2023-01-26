using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CanHazFunny.Tests;

[TestClass]
public class JesterTests
{
    [TestMethod]
    public void TellJoke()
    {
        StringWriter stringWriter = new();
        Console.SetOut(stringWriter);

        // Arrange
        Jester jester = new();

        // Act
        jester.TellJoke();

        // Assert
        Assert.IsTrue(stringWriter.ToString().Length > 0);
    }
}
