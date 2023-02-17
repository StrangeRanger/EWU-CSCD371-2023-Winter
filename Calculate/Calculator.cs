namespace Calculate;

public class Calculator
{
    public static IReadOnlyDictionary<char,MyMath> MathematicalOperations { get; } = new Dictionary<char,MyMath>
    {
        {'+', Add},
        {'-', Subtract},
        {'*', Multiply},
        {'/', Divide}
    };

    public delegate double MyMath (double a, double b);
    
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

    public delegate string ReadDelegate();
    public delegate void WriteDelegate(string line);
    
    public static string ReadLine()
    {
        return Console.ReadLine()!;
    }
    public static void WriteLine(string line)
    {
        Console.WriteLine(line);
    }
    
    public void TryCalculate(WriteDelegate writeLine, ReadDelegate readLine)
    {
        ReadDelegate readDelegate = readLine;
        WriteDelegate writeDelegate = writeLine;
        string input = readDelegate();
        if (!input.Contains(" "))
        {
            throw new ArgumentException("Input must contain a space");
        }

        string[] parts = input.Split(' ');;
        double a = double.Parse(parts[0]);
        double b = double.Parse(parts[2]);
        char operation = parts[1].ToCharArray()[0];
        double result;

        MyMath myDelegate = MathematicalOperations[operation];
        result = myDelegate(a, b);
        
        writeDelegate(result.ToString());
    }
    
}
