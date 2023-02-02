using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class FullNameTest
{
    [TestMethod]
    public void No_Middle_Name()
    {
        var fullName = new FullName("John", "Doe");
        Assert.AreEqual("John Doe", fullName.ToString());
    }
    [TestMethod]
    public void With_Middle_Name()
    {
        var fullName = new FullName("John", "Doe", "Smith");
        Assert.AreEqual("John Doe Smith", fullName.ToString());
    }
}