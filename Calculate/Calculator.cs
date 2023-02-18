namespace Calculate;

public class Calculator
{
    public static IReadOnlyDictionary<char, Func<double, double, double> > MathematicalOperations {
        get;
    } = new Dictionary<char, Func<double, double, double> > {
        { '+', Add },
        { '-', Subtract },
        { '*', Multiply },
        { '/', Divide }
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
    
public void Calculate(WriteDelegate writeLine, ReadDelegate readLine)
    {
        string input = readLine();
        if (!input.Contains(" "))
        {
            throw new ArgumentException("Input must contain a spaces");
        }
        if (TryCalculate(input))
        {
            string[] parts = input.Split(' ');;
            double a = double.Parse(parts[0]);
            double b = double.Parse(parts[2]);
            char operation = parts[1].ToCharArray()[0];
            double result;

            Func<double, double, double> myDelegate = MathematicalOperations[operation];
            result = myDelegate(a, b);

            writeLine(result.ToString());
        } 
    }
    
    public Boolean TryCalculate(string input)
    {
        try
        {
            string[] parts = input.Split(' ');;
            double a = double.Parse(parts[0]);
            double b = double.Parse(parts[2]);
            char operation = parts[1].ToCharArray()[0];
        } 
        catch (Exception e)
        {
            Console.WriteLine("There was an error with your problem: " + e.Message);
            return false;
        }
        return true;
    }

}
