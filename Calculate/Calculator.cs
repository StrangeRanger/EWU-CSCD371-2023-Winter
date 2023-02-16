namespace Calculate;

public class Calculator<TValue>
{

    public IReadOnlyDictionary<char, TValue> MathematicalOperations { get; } = new Dictionary<char, TValue>();
    
    public TValue Add(TValue a, TValue b)
    {
        return a + b;
    }
    
    public TValue Subtract(TValue a, TValue b)
    {
        return a - b;
    }

    public TValue Multiply(TValue a, TValue b)
    {
        return a * b;
    }

    public TValue Divide(TValue a, TValue b)
    {
        int.TryParse(a, b);
        return a / b;
    }

    
    
    public void TryCalculate()
    {
        
    }
    
    
}
