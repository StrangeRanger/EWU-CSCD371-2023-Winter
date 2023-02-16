namespace Calculate.Tests;

[TestClass]
public class CalculatorTest
{
    [TestMethod]
    public void Calculate_Int()
    {
        Calculator<int> calculator = new();
        int total = calculator.Add(1, 2);

        Assert.AreEqual(3, total);
    }
    
    [TestMethod]
    public void Calculate_Double()
    {

    }
    
    [TestMethod]
    public void Calculate_Float()
    { 

        
    }
}
