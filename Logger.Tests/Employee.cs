using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class Employee
{
    [TestMethod]
    public void Create_Employee()
    {
        var employee = new Employee();
        Assert.AreEqual("John Doe Smith", employee.ToString());
    }

}