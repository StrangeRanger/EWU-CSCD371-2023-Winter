using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CanHazFunny.Tests;

[TestClass]
public class JesterTests
{
    [TestMethod]
    public void TellJoke_ShouldNotContainChuckNorris()
    {
        StringWriter stringWriter = new();
        Console.SetOut(stringWriter);

        // Arrange
        Jester jester = new();

        // Act
        jester.TellJoke();

        // Assert
        Assert.IsFalse(stringWriter.ToString().Contains("Chuck Norris"));
    }

    [TestMethod]
    public void TellJoke_ShouldNotReturnNull()
    {
        // Arrange
        Jester jester = new();

        // Act
        String joke = jester.GetJoke();

        // Assert
        Assert.IsNotNull(joke);
    }
}
