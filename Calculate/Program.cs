namespace Calculate;

public class Program
{
    private  Delegate WriteLine { get; init; }
    private Delegate ReadLine { get; init; }
    
    public Program()
    {
        WriteLine = Calculator.WriteLine;
        ReadLine = Calculator.ReadLine;
    }

    public void tryCalculate()
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
