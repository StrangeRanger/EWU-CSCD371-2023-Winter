using System;
namespace Logger.Tests;

[TestClass]
public class EmployeeTest
{
    [TestMethod]
    public void Create_Employee()
    {
        FullName fullName = new FullName("John", "Doe");
        Employee employee = new Employee(Guid.NewGuid(), fullName);
        
        Assert.AreEqual("John Doe", employee.Name);
        Assert.AreEqual("John", employee.FirstName);
        Assert.AreEqual("Doe", employee.LastName);
        Assert.IsNull(employee.MiddleName);
    }
    
    [TestMethod]
    public void Create_Employee_WithMiddleName()
    {
        FullName fullName = new FullName("John", "Doe", "Michael");
        Employee employee = new Employee(Guid.NewGuid(), fullName);
        
        Assert.AreEqual("John Michael Doe", employee.Name);
        Assert.AreEqual("John", employee.FirstName);
        Assert.AreEqual("Michael", employee.MiddleName);
        Assert.AreEqual("Doe", employee.LastName);
    }
    
    [TestMethod]
    public void AreSame_Employee()
    {
        Guid id = Guid.NewGuid();
        FullName fullName = new FullName("John", "Doe");
        Employee employee1 = new Employee(id, fullName);
        Employee employee2 = new Employee(id, fullName);
        
        Assert.IsTrue(employee1.Equals(employee2));
    }
}