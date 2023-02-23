namespace Calculate.Tests;

[TestClass]
public class CalculatorTest
{
    #pragma warning disable CS8618
    private Calculator Calculator { get; set; }
    #pragma warning restore CS8618

    [TestInitialize]
    public void TestInitialize()
    {
        TestCleanup();
        Calculator = new Calculator();
    }

    [TestCleanup]
    public void TestCleanup()
    {
        Calculator = null !;
    }

    [TestMethod]
    [DataRow("15 + 100", true)]
    [DataRow("15 - 100", true)]
    [DataRow("15 * 100", true)]
    [DataRow("15 / 100", true)]
    [DataRow("15 : 100", false)]
    public void Calculator_TryCalculate_AreEqualIfValidOperator(string userInput, bool expected)
    {
        bool actual = Calculator.TryCalculate(userInput);

        Assert.AreEqual<bool>(expected, actual);

    }

    [TestMethod]
    [DataRow("15 + 100", true)]
    [DataRow("15.5 + 100.5", false)]
    [DataRow("Hello + World", false)]
    [DataRow("a + b", false)]
    public void Calculator_TryCalculate_AreEqualIfInputIsOfTypeInt(string userInput, bool expected)
    {
        bool actual = Calculator.TryCalculate(userInput);

        Assert.AreEqual<bool>(expected, actual);

    }

    [TestMethod]
    [DataRow("15 +100", false)]
    [DataRow("15- 100", false)]
    [DataRow("15*100", false)]
    public void Calculator_TryCalculate_AreEqualIfCorrectFormat(string userInput, bool expected)
    {
        bool actual = Calculator.TryCalculate(userInput);

        Assert.AreEqual<bool>(expected, actual);
    }

    [TestMethod]
    [DataRow("15 +", false)]
    [DataRow("15-", false)]
    [DataRow("* 100", false)]
    [DataRow("/100", false)]
    public void Calculator_TryCalculate_AreEqualIfInputIsTooShort(string userInput, bool expected)
    {
        bool actual = Calculator.TryCalculate(userInput);

        Assert.AreEqual<bool>(expected, actual);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Calculator_TryCalculate_ArgumentNullException()
    {
        _ = Calculator.TryCalculate(null !);
    }

    [TestMethod]
    public void Calculator_TryCalculate_AreEqualIfInputIsEmpty()
    {
        bool actual = Calculator.TryCalculate("");

        Assert.AreEqual<bool>(false, actual);
    }

    [TestMethod]
    public void Calculator_TryCalculate_AreEqualIfInputIsWhiteSpace()
    {
        bool actual = Calculator.TryCalculate(" ");

        Assert.AreEqual<bool>(false, actual);
    }

    [TestMethod]
    [DataRow("15 + 100", "115")]
    [DataRow("15 - 100", "-85")]
    [DataRow("15 * 100", "1500")]
    [DataRow("15 / 100", "0.15")]
    public void Calculator_Calculate_AreEqualAllOperators(string userInput, string expected)
    {
        ProgramBase program = new();
        StringWriter stringWriter = new();
        Console.SetOut(stringWriter);

        Calculator.Calculate(program.WriteLine, () => userInput);

        Assert.AreEqual<string>(expected, stringWriter.ToString().Trim());
    }

    [TestMethod]
    public void Calculator_MathematicalOperations()
    {
        Assert.AreEqual<double>(5, Calculator.MathematicalOperations['+'](2, 3));
        Assert.AreEqual<double>(-1, Calculator.MathematicalOperations['-'](2, 3));
        Assert.AreEqual<double>(6, Calculator.MathematicalOperations['*'](2, 3));
        Assert.AreEqual<double>(2, Calculator.MathematicalOperations['/'](6, 3));
    }

}
