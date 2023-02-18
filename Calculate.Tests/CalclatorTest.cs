namespace Calculate.Tests;

[TestClass]
public class CalculatorTest
{
    [TestMethod]
    public void Calculate_Int()
    {
        StringWriter stringWriter = new();
        Console.SetOut(stringWriter);
        
        Calculator.TryCalculate(Calculator.WriteLine, () => "15 + 100");
        
        string expected = "115";
        Assert.AreEqual(expected, stringWriter.ToString().Trim());
    }
    
    [TestMethod]
    public void Calculate_Double()
    {
        StringWriter stringWriter = new();
        Console.SetOut(stringWriter);
        
        Calculator.TryCalculate(Calculator.WriteLine, () => "15.75 + 100.25");
        
        string expected = "116";
        Assert.AreEqual(expected, stringWriter.ToString().Trim());
    }
    
    [TestMethod]
    public void Calculate_Char()
    {
        StringWriter stringWriter = new();
        Console.SetOut(stringWriter);
        
        Calculator.TryCalculate(Calculator.WriteLine, () => "a + b");
        
        string expected = ('a' + 'b').ToString();
        Assert.AreNotEqual(expected, stringWriter.ToString().Trim());
    }
    
    [TestMethod]
    public void Calculate_String()
    {
        StringWriter stringWriter = new();
        Console.SetOut(stringWriter);
        
        Calculator.TryCalculate(Calculator.WriteLine, () => "Hello + World");
        
        string expected = "Hello World";
        Assert.AreNotEqual(expected, stringWriter.ToString().Trim());
    }
    
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
