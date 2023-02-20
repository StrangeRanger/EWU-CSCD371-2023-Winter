namespace Calculate;

public class Calculator
{
    public IReadOnlyDictionary<char, Func<int, int, double> > MathematicalOperations {
        get;
    } = new Dictionary<char, Func<int, int, double> > {
        { '+', Add },
        { '-', Subtract },
        { '*', Multiply },
        { '/', Divide }
    };

    public static double Add(int a, int b)
    {
        return a + b;
    }

    public static double Subtract(int a, int b)
    {
        return a - b;
    }

    public static double Multiply(int a, int b)
    {
        return a * b;
    }

    public static double Divide(int a, int b)
    {
        return (double) a / b;
    }

    // TODO: Should probably be re-written...
    public bool TryCalculate(Func<string> readLine)
    {
        // TODO: ???
        string input = readLine() ?? throw new ArgumentNullException(typeof(string).ToString());
        string[] parts = input.Split(' ');
        
        try
        {
            _ = int.Parse(parts[0]);
            _ = int.Parse(parts[2]);
            char operation = parts[1].ToCharArray()[0];
            
            if (! MathematicalOperations.ContainsKey(operation)) { return false; }
        } 
        catch (Exception e) when (e is IndexOutOfRangeException or FormatException)
        {
            return false;
        }

        return true;
    }
    
    // TODO: Should probably be re-written...
    public void Calculate(Action<string> writeLine, Func<string?> readLine)
    {
        // TODO: ???
        string input = readLine() ?? throw new ArgumentNullException(typeof(string).ToString());
        string[] parts = input.Split(' ');
        int a, b;
        char operation;

        try
        {
            a = int.Parse(parts[0]);
            b = int.Parse(parts[2]);
            operation = parts[1].ToCharArray()[0];
        } 
        catch (Exception e) when (e is IndexOutOfRangeException or FormatException)
        {
            writeLine("Invalid input");
            return;
        }
        
        Func<int, int, double> myDelegate = MathematicalOperations[operation];
        double result = myDelegate(a, b);

        writeLine(result.ToString());
    }
}
