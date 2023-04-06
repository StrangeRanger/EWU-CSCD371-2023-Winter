using System.Globalization;
namespace Calculate;

public class Calculator
{
    public IReadOnlyDictionary<char, Func<int, int, double>> MathematicalOperations { get; } =
        new Dictionary<char, Func<int, int, double>> {
            { '+', Add }, { '-', Subtract }, { '*', Multiply }, { '/', Divide } };

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
        return (double)a / b;
    }

    public bool TryCalculate(string input)
    {
        string[] parts = input.Split(' ');

        try
        {
            _ = int.Parse(parts[0]);
            _ = int.Parse(parts[2]);
            char operation = parts[1].ToCharArray()[0];

            if (!MathematicalOperations.ContainsKey(operation))
            {
                return false;
            }
        }
        catch (Exception e) when (e is IndexOutOfRangeException or FormatException)
        {
            Console.Error.WriteLine(e.Message);
            return false;
        }

        return true;
    }

    public void Calculate(Action<string> writeLine, Func<string?> readLine)
    {
        string input = readLine() ?? throw new ArgumentNullException(nameof(readLine));
        string[] parts = input.Split(' ');

        if (!TryCalculate(input))
        {
            return;
        }

        int a = int.Parse(parts[0]);
        int b = int.Parse(parts[2]);
        char operation = parts[1].ToCharArray()[0];

        Func<int, int, double> myDelegate = MathematicalOperations[operation];
        double result = myDelegate(a, b);

        writeLine(result.ToString(CultureInfo.CurrentCulture));
    }
}
