namespace Calculate.Tests;

[TestClass]
public class ProgramTest
{
    private Program Program { get; set; }

    [TestInitialize]
    public void TestInitialize()
    {
        TestCleanup();
        Program = new Program();
    }

    [TestCleanup]
    public void TestCleanup()
    {
        Program = null;
    }
    
    [TestMethod]
    public void Program_WriteLine()
    {
        StringWriter stringWriter = new();
        Console.SetOut(stringWriter);
        
        Program.WriteLine("Hello World");

        Assert.AreEqual("Hello World", stringWriter.ToString().Trim());
    }
    
    [TestMethod]
    public void Program_ReadLine()
    {
        StringReader stringReader = new("Hello World");
        Console.SetIn(stringReader);
        
        string? actual = Program.ReadLine();

        Assert.AreEqual("Hello World", actual);
    }
}
