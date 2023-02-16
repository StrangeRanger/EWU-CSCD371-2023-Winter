namespace Calculate;

public class CalculatorUser
{
    private IReadOnlyDictionary<string,Delegate> MathematicalOperations { get; } = new Dictionary<string,Delegate>
    {
        {"+", Calculator.Add},
        {"-", Calculator.Subtract},
        {"*", Calculator.Multiply},
        {"/", Calculator.Divide}
    };

    
    
    public string Calculate(string input)
    {
        var parts = input.Split(' ');
        var a = double.Parse(parts[0]);
        var b = double.Parse(parts[2]);
        var operation = parts[1];
        var result = MathematicalOperations[operation].DynamicInvoke(a, b);
        return result.ToString();
    }

}