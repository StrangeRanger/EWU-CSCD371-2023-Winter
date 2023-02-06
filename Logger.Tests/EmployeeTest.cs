using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class EmployeeTest
{
    [TestMethod]
    public void Create_Employee()
    {
        Employee employee = new Employee(Guid.NewGuid(), "John Doe");
        Assert.AreEqual("John Doe", employee.Name);
        Assert.AreEqual("John", employee.FirstName);
        Assert.AreEqual("Doe", employee.LastName);
        Assert.IsNull(employee.MiddleName);
    }
    
    [TestMethod]
    public void Create_Employee_WithMiddleName()
    {
        Employee employee = new Employee(Guid.NewGuid(), "John Doe Michael");
        Assert.AreEqual("John Michael Doe", employee.Name);
        Assert.AreEqual("John", employee.FirstName);
        Assert.AreEqual("Doe", employee.LastName);
        Assert.AreEqual("Michael", employee.MiddleName);
    }
}