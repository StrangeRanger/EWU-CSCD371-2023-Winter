using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class BookTest
{
    
    [TestMethod]
    public void Create_Book()
    {
        var book = new Book("The Hobbit", "J.R.R. Tolkien");
        Assert.AreEqual("The Hobbit", book.Name);
        Assert.AreEqual("J.R.R. Tolkien", book.Author);
        Assert.AreEqual("The Hobbit by J.R.R. Tolkien", book.ToString());
    }
    
    [TestMethod]
    public void AreSame_Book()
    {
        var book1 = new Book("The Hobbit", "J.R.R. Tolkien");
        var book2 = new Book("The Hobbit", "J.R.R. Tolkien");
        Assert.IsTrue(book1.Equals(book2));
    }
}