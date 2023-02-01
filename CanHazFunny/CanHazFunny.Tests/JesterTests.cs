using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CanHazFunny.Tests;

[TestClass]
public class JesterTests
{
    private Jester? Jester { get; set; }

    [TestInitialize]
    public void TestInitialize()
    {
        TestCleanup();
        Jester = new Jester(new JokeOutput(), new JokeService());
    }

    [TestCleanup]
    public void TestCleanup()
    {
        Jester = null;
    }

    [TestMethod]
    public void TellJoke_ShouldNotContainChuckNorris()
    {
        StringWriter stringWriter = new();
        Console.SetOut(stringWriter);

        // Act
        Jester?.TellJoke();

        // Assert
        Assert.IsFalse(stringWriter.ToString().Contains("Chuck Norris"));
    }
    
    [TestMethod]
    public void TellJoke_ShouldNotBeNull()
    {
        StringWriter stringWriter = new();
        Console.SetOut(stringWriter);

        // Act
        Jester?.TellJoke();

        // Assert
        Assert.IsNotNull(stringWriter.ToString());
    }
}
