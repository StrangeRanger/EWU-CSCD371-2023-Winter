namespace Calculate;

public class Calculator
{
    public static IReadOnlyDictionary<char,Delegate> MathematicalOperations { get; } = new Dictionary<char,Delegate>
    {
        {'+', Calculator.Add},
        {'-', Calculator.Subtract},
        {'*', Calculator.Multiply},
        {'/', Calculator.Divide}
    };

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

    public static string ReadLine()
    {
        return Console.ReadLine();
    }
    public static void WriteLine(string line)
    {
        Console.WriteLine(line);
    }
    
    public void tryCalculate(Delegate WriteLine, Delegate ReadLine)
    {
        string input = ReadLine.DynamicInvoke()!.ToString()!;
        if (!input.Contains(" "))
        {
            throw new ArgumentException("Input must contain a space");
        }

        string[] parts;
        double a;
        double b;
        char operation;
        object result;
        
        parts = input.Split(' ');
        a = double.Parse(parts[0]);
        b = double.Parse(parts[2]);
        operation = parts[1].ToCharArray()[0];
        
        result = Calculator.MathematicalOperations[operation].DynamicInvoke(a, b);
        WriteLine.DynamicInvoke(result);
    }
    
}
