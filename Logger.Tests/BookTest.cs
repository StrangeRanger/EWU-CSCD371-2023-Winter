using System;
namespace Logger.Tests;

[TestClass]
public class BookTest
{
    
    [TestMethod]
    public void Create_Book()
    {
        FullName fullName = new FullName("J.R.R.", "Tolkien");
        Book book = new Book(Guid.NewGuid(), fullName, "The Hobbit");
        
        Assert.AreEqual("The Hobbit", book.Title);
        Assert.AreEqual("J.R.R. Tolkien", book.Name);
    }
    
    [TestMethod]
    public void AreSame_Book()
    {
        Guid id = Guid.NewGuid();
        FullName fullName = new FullName("J.R.R.", "Tolkien");
        Book book1 = new Book(id, fullName, "The Hobbit");
        Book book2 = new Book(id, fullName, "The Hobbit");
        
        Assert.IsTrue(book1.Equals(book2));
    }
}