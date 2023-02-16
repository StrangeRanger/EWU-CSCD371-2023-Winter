namespace Calculate;

public class Program
{
    public Delegate WriteLine { get; init; }
    public Delegate ReadLine { get; init; }
    public static void Main()
    {
        Console.WriteLine("Hello World!");
        string equation = "72 - 8";
        Console.WriteLine(equation+" = "+Calculate(equation));
    }
    
    public static string Calculate(string input)
    {
        var parts = input.Split(' ');
        var a = double.Parse(parts[0]);
        var b = double.Parse(parts[2]);
        var operation = parts[1];
        var result = Calculator.MathematicalOperations[operation].DynamicInvoke(a, b);
        return result.ToString();
    }
    
}
