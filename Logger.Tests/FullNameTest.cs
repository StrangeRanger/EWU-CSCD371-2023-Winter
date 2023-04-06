namespace Logger.Tests;

[TestClass]
public class FullNameTest
{
    [TestMethod]
    public void No_Middle_Name()
    {
        // Arrange
        FullName fullName = new FullName("John", "Doe");

        // Assert
        Assert.AreEqual("John Doe", fullName.ToString());
    }

    [TestMethod]
    public void With_Middle_Name()
    {
        // Arrange
        FullName fullName = new FullName("John", "Doe", "Smith");

        // Assert
        Assert.AreEqual("John Smith Doe", fullName.ToString());
    }
}
