namespace Calculate.Tests;

[TestClass]
public class ProgramTest
{
#pragma warning disable CS8618
    private ProgramBase Program { get; set; }
#pragma warning restore CS8618

    [TestInitialize]
    public void TestInitialize()
    {
        TestCleanup();
        Program = new ProgramBase();
    }

    [TestCleanup]
    public void TestCleanup()
    {
        Program = null!;
    }

    [TestMethod]
    public void Program_WriteLine()
    {
        StringWriter stringWriter = new();
        Console.SetOut(stringWriter);

        Program.WriteLine("Hello World");

        Assert.AreEqual<string>("Hello World", stringWriter.ToString().Trim());
    }

    [TestMethod]
    public void Program_WriteLinePerformInitSetter_AreEqual()
    {
        ProgramBase customProgram =
            new() { WriteLine = s => Assert.AreEqual<string>("Hello World", s) };

        customProgram.WriteLine("Hello World");
    }

    [TestMethod]
    public void Program_ReadLine()
    {
        StringReader stringReader = new("Hello World");
        Console.SetIn(stringReader);

        string? actual = Program.ReadLine();

        Assert.AreEqual<string>("Hello World", actual!);
    }

    [TestMethod]
    public void Program_ReadLinePerformInitSetter_AreEqual()
    {
        ProgramBase customProgram = new() { ReadLine = () => "Hello World" };

        string? actual = customProgram.ReadLine();

        Assert.AreEqual<string>("Hello World", actual!);
    }
}
