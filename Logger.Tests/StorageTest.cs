using System;
namespace Logger.Tests;

[TestClass]
public class StorageTest
{
    [TestMethod]
    public void Add_Student()
    {
        Storage storage = new Storage();
        FullName fullName = new FullName("John", "Doe");
        Student student = new Student(Guid.NewGuid(), fullName);
        
        storage.Add(student);
        
        Assert.IsTrue(storage.Contains(student));
    }

    [TestMethod]
    public void Add_Employee()
    {
        Storage storage = new Storage();
        FullName fullName = new FullName("John", "Doe");
        Employee employee = new Employee(Guid.NewGuid(), fullName);
        
        storage.Add(employee);
        
        Assert.IsTrue(storage.Contains(employee));
    }
    
    [TestMethod]
    public void Add_Book()
    {
        Storage storage = new Storage();
        FullName fullName = new FullName("John", "Doe");
        Book book = new Book(Guid.NewGuid(), fullName, "The Hitchhiker's Guide to the Galaxy");
        
        storage.Add(book);
        
        Assert.IsTrue(storage.Contains(book));
    }
    
    [TestMethod]
    public void Add_All()
    {
        Storage storage = new Storage();
        FullName fullName = new FullName("John", "Doe");
        FullName fullName2 = new FullName("John", "Doe", "Smith");
        Student student = new Student(Guid.NewGuid(), fullName);
        Employee employee = new Employee(Guid.NewGuid(), fullName);
        Book book = new Book(Guid.NewGuid(), fullName2, "The Hitchhiker's Guide to the Galaxy");
        
        storage.Add(student);
        storage.Add(employee);
        storage.Add(book);
        
        Assert.IsTrue(storage.Contains(student));
        Assert.IsTrue(storage.Contains(employee));
        Assert.IsTrue(storage.Contains(book));
    }

    [TestMethod]
    public void Remove_Student()
    {
        Storage storage = new Storage();
        FullName fullName = new FullName("John", "Doe");
        Student student = new Student(Guid.NewGuid(), fullName);
        
        storage.Add(student);
        storage.Remove(student);
        
        Assert.IsFalse(storage.Contains(student));
    }

    [TestMethod]
    public void Remove_Employee()
    {
        Storage storage = new Storage();
        FullName fullName = new FullName("John", "Doe");
        Employee employee = new Employee(Guid.NewGuid(), fullName);
        
        storage.Add(employee);
        storage.Remove(employee);
        
        Assert.IsFalse(storage.Contains(employee));
    }
    
    [TestMethod]
    public void Remove_Book()
    {
        Storage storage = new Storage();
        FullName fullName = new FullName("Douglas", "Adams");
        Book book = new Book(Guid.NewGuid(), fullName, "The Hitchhiker's Guide to the Galaxy");
        
        storage.Add(book);
        storage.Remove(book);
        
        Assert.IsFalse(storage.Contains(book));
    }

    [TestMethod]
    public void Get_Student()
    {
        Storage storage = new Storage();
        FullName fullName = new FullName("John", "Doe");
        Student student = new Student(Guid.NewGuid(), fullName);
        
        storage.Add(student);
        
        Assert.AreEqual(student, storage.Get(student.Id));
    }

    [TestMethod]
    public void Get_Employee()
    {
        Storage storage = new Storage();
        FullName fullName = new FullName("John", "Doe");
        Employee employee = new Employee(Guid.NewGuid(), fullName);
        
        storage.Add(employee);
        
        Assert.AreEqual(employee, storage.Get(employee.Id));
    }

    [TestMethod]
    public void Get_Student_With_Wrong_Id()
    {
        Storage storage = new Storage();
        FullName fullName = new FullName("John", "Doe");
        Student student = new Student(Guid.NewGuid(), fullName);
        
        storage.Add(student);
        
        Assert.IsNull(storage.Get(Guid.NewGuid()));
    }

}    