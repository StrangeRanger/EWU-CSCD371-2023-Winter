using System;
namespace Logger.Tests;

[TestClass]
public class StudentTest
{
    [TestMethod]
    public void Create_Student()
    {
        FullName fullName = new FullName("John", "Doe");
        Student student = new Student(Guid.NewGuid(), fullName);
        
        Assert.AreEqual("John Doe", student.Name);
        Assert.AreEqual("John", student.FirstName);
        Assert.AreEqual("Doe", student.LastName);
        Assert.IsNull(student.MiddleName);
    }
    
    [TestMethod]
    public void Create_Student_WithMiddleName()
    {
        FullName fullName = new FullName("John", "Doe", "Michael");
        Student student = new Student(Guid.NewGuid(), fullName);
        
        Assert.AreEqual("John Michael Doe", student.Name);
        Assert.AreEqual("John", student.FirstName);
        Assert.AreEqual("Doe", student.LastName);
        Assert.AreEqual("Michael", student.MiddleName);
    }
    
    [TestMethod]
    public void AreSame_Student()
    {
        Guid id = Guid.NewGuid();
        FullName fullName = new FullName("John", "Doe");
        Student student1 = new Student(id, fullName);
        Student student2 = new Student(id, fullName);
        Assert.IsTrue(student1.Equals(student2));
    }
    
}