namespace Calculate.Tests;

[TestClass]
public class ProgramTest
{
    [TestMethod]
    public void Program_WriteLine()
    {
        StringWriter stringWriter = new();
        Console.SetOut(stringWriter);

        Program program = new();
        program.WriteLine("Hello World");

        Assert.AreEqual("Hello World", stringWriter.ToString().Trim());
    }
    
    [TestMethod]
    public void Program_ReadLine()
    {
        StringReader stringReader = new("Hello World");
        Console.SetIn(stringReader);

        Program program = new();
        string? actual = program.ReadLine();

        Assert.AreEqual("Hello World", actual);
    }
}
