using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CanHazFunny.Tests;

[TestClass]
public class JesterTests
{
    private Jester? Jester { get; set; }
    
    [TestInitialize]
    public  void TestInitialize()
    {
        TestCleanup();
        Jester = new Jester();
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
        Jester.TellJoke();

        // Assert
        Assert.IsFalse(stringWriter.ToString().Contains("Chuck Norris"));
    }

    [TestMethod]
    public void TellJoke_ShouldNotReturnNull()
    {
        // Act
        string joke = Jester.GetJoke();

        // Assert
        Assert.IsNotNull(joke);
    }

    [TestMethod]
    public void Jester_Initialize_IsNotNull() {
        Assert.IsNotNull(Jester);
    }

}
