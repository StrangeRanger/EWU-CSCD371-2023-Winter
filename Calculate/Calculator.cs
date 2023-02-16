namespace Calculate;

public class Calculator
{
    public static IReadOnlyDictionary<string,Delegate> MathematicalOperations { get; } = new Dictionary<string,Delegate>
    {
        {"+", Calculator.Add},
        {"-", Calculator.Subtract},
        {"*", Calculator.Multiply},
        {"/", Calculator.Divide}
    };
    
    public delegate double KeySelector(double a, double b);
    
    public static double Add(double a, double b)
    {
        return a + b;
    }
    public static double Subtract(double a, double b)
    {
        return a - b;
    }
    public static double Multiply(double a, double b)
    {
        return a * b;
    }
    public static double Divide(double a, double b)
    {
        return a / b;
    }

}
