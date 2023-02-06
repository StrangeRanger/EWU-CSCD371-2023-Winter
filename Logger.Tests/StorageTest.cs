using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class StorageTest
{
    [TestMethod]
    public void Add_Student()
    {
        Storage storage = new Storage();
        Student student = new Student(Guid.NewGuid(), "John Doe");
        storage.Add(student);
        Assert.IsTrue(storage.Contains(student));
    }

    [TestMethod]
    public void Add_Employee()
    {
        Storage storage = new Storage();
        Employee employee = new Employee(Guid.NewGuid(), "John Doe");
        storage.Add(employee);
        Assert.IsTrue(storage.Contains(employee));
    }

    [TestMethod]
    public void Remove_Student()
    {
        Storage storage = new Storage();
        Student student = new Student(Guid.NewGuid(), "John Doe");
        storage.Add(student);
        storage.Remove(student);
        Assert.IsFalse(storage.Contains(student));
    }

    [TestMethod]
    public void Remove_Employee()
    {
        Storage storage = new Storage();
        Employee employee = new Employee(Guid.NewGuid(), "John Doe");
        storage.Add(employee);
        storage.Remove(employee);
        Assert.IsFalse(storage.Contains(employee));
    }

    [TestMethod]
    public void Get_Student()
    {
        Storage storage = new Storage();
        Student student = new Student(Guid.NewGuid(), "John Doe");
        storage.Add(student);
        Assert.AreEqual(student, storage.Get(student.Id));
    }

    [TestMethod]
    public void Get_Employee()
    {
        Storage storage = new Storage();
        Employee employee = new Employee(Guid.NewGuid(), "John Doe");
        storage.Add(employee);
        Assert.AreEqual(employee, storage.Get(employee.Id));
    }

    [TestMethod]
    public void Get_Student_With_Wrong_Id()
    {
        Storage storage = new Storage();
        Student student = new Student(Guid.NewGuid(), "John Doe");
        storage.Add(student);
        Assert.IsNull(storage.Get(Guid.NewGuid()));
    }

}    