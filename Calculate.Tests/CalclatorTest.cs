namespace Calculate.Tests;

[TestClass]
public class CalculatorTest
{
    [TestMethod]
    public void Calculate_Int()
    {
        StringWriter stringWriter = new();
        Console.SetOut(stringWriter);

        Program program = new();
        Calculator.TryCalculate(program.WriteLine, () => "15 + 100");

        Assert.AreEqual("115", stringWriter.ToString().Trim());
    }
    
    [TestMethod]
    public void Calculate_Double()
    {
        StringWriter stringWriter = new();
        Console.SetOut(stringWriter);
        
        Program program = new();
        Calculator.TryCalculate(program.WriteLine, () => "15.75 + 100.25");

        Assert.AreEqual("116", stringWriter.ToString().Trim());
    }
    
    // [TestMethod]
    // public void Calculate_Char()
    // {
    //     StringWriter stringWriter = new();
    //     Console.SetOut(stringWriter);
    //     
    //     Program program = new();
    //     Calculator.TryCalculate(program.WriteLine, () => "a + b");
    //     
    //
    //     Assert.AreNotEqual(('a' + 'b').ToString(), stringWriter.ToString().Trim());
    // }
    //
    // [TestMethod]
    // public void Calculate_String()
    // {
    //     StringWriter stringWriter = new();
    //     Console.SetOut(stringWriter);
    //     
    //     Program program = new();
    //     Calculator.TryCalculate(program.WriteLine, () => "Hello + World");
    //     
    //     string expected = "Hello World";
    //     Assert.AreNotEqual(expected, stringWriter.ToString().Trim());
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
    //     StringWriter stringWriter = new();
    //     Console.SetOut(stringWriter);
    //     Calculator.WriteDelegate writeDelegate = Calculator.WriteLine;
    //     writeDelegate("Hello World");
    //     Assert.AreEqual("Hello World", stringWriter.ToString().Trim());
    //     
    //     Calculator.ReadDelegate readDelegate = () => "Hello World";
    //     Assert.AreEqual("Hello World", readDelegate());
    // }
}
