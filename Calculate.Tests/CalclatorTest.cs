namespace Calculate.Tests;

[TestClass]
public class CalculatorTest
{
    private Program Program { get; set; }
    private Calculator Calculator { get; set; }
    private StringWriter StringWriter { get; set; }

    [TestInitialize]
    public void TestInitialize()
    {
        TestCleanup();
        Program = new Program();
        Calculator = new Calculator();
        StringWriter = new StringWriter();
    }

    [TestCleanup]
    public void TestCleanup()
    {
        Program = null;
        Calculator = null;
        StringWriter = null;
    }
    
    [TestMethod]
    public void Calculate_Int()
    {
        Console.SetOut(StringWriter);

        Calculator.TryCalculate(Program.WriteLine, () => "15 + 100");

        Assert.AreEqual("115", StringWriter.ToString().Trim());
    }
    
    [TestMethod]
    public void Calculate_Double()
    {
        Console.SetOut(StringWriter);
        
        Calculator.TryCalculate(Program.WriteLine, () => "15.75 + 100.25");

        Assert.AreEqual("116", StringWriter.ToString().Trim());
    }
    
    // [TestMethod]
    // public void Calculate_Char()
    // {
    //     StringWriter StringWriter = new();
    //     Console.SetOut(StringWriter);
    //     
    //     Program program = new();
    //     Calculator.TryCalculate(program.WriteLine, () => "a + b");
    //     
    //
    //     Assert.AreNotEqual(('a' + 'b').ToString(), StringWriter.ToString().Trim());
    // }
    //
    // [TestMethod]
    // public void Calculate_String()
    // {
    //     StringWriter StringWriter = new();
    //     Console.SetOut(StringWriter);
    //     
    //     Program program = new();
    //     Calculator.TryCalculate(program.WriteLine, () => "Hello + World");
    //     
    //     string expected = "Hello World";
    //     Assert.AreNotEqual(expected, StringWriter.ToString().Trim());
    // }
    
    // [TestMethod]
    // public void Calculator_Delegates()
    // {
    //     Calculator.MyMath myMath = Calculator.Add;
    //     Assert.AreEqual(5, myMath(2, 3));
    //     myMath = Calculator.Subtract;
    //     Assert.AreEqual(-1, myMath(2, 3));
    //     myMath = Calculator.Multiply;
    //     Assert.AreEqual(6, myMath(2, 3));
    //     myMath = Calculator.Divide;
    //     Assert.AreEqual(2, myMath(6, 3));
    //     
    //     StringWriter StringWriter = new();
    //     Console.SetOut(StringWriter);
    //     Calculator.WriteDelegate writeDelegate = Calculator.WriteLine;
    //     writeDelegate("Hello World");
    //     Assert.AreEqual("Hello World", StringWriter.ToString().Trim());
    //     
    //     Calculator.ReadDelegate readDelegate = () => "Hello World";
    //     Assert.AreEqual("Hello World", readDelegate());
    // }
    
    [TestMethod]
    public void Calculator_MathematicalOperations()
    {
        Assert.AreEqual(5, Calculator.MathematicalOperations['+'](2, 3));
        Assert.AreEqual(-1, Calculator.MathematicalOperations['-'](2, 3));
        Assert.AreEqual(6, Calculator.MathematicalOperations['*'](2, 3));
        Assert.AreEqual(2, Calculator.MathematicalOperations['/'](6, 3));
    }
    
}
