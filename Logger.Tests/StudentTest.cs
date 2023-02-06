using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class StudentTest
{
    [TestMethod]
    public void Create_Student()
    {
        Student student = new Student(Guid.NewGuid(), "John Doe");
        Assert.AreEqual("John Doe", student.Name);
        Assert.AreEqual("John", student.FirstName);
        Assert.AreEqual("Doe", student.LastName);
        Assert.IsNull(student.MiddleName);
    }
    
    [TestMethod]
    public void Create_Student_WithMiddleName()
    {
        Student student = new Student(Guid.NewGuid(), "John Michael Doe");
        Assert.AreEqual("John Doe Michael", student.Name);
        Assert.AreEqual("John", student.FirstName);
        Assert.AreEqual("Doe", student.LastName);
        Assert.AreEqual("Michael", student.MiddleName);
    }
    
    [TestMethod]
    public void AreSame_Student()
    {
        Guid id = Guid.NewGuid();
        Student student1 = new Student(id, "John Doe");
        Student student2 = new Student(id, "John Doe");
        Assert.IsTrue(student1.Equals(student2));
    }
    
}