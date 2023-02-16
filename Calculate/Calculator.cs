namespace Calculate;

public class Calculator<TKey, TValue> where TKey : struct where TValue : struct
{
    private IReadOnlyDictionary<TKey, TValue> MathematicalOperations { get; } = new Dictionary<TKey, TValue>
    {
        { (TKey)Convert.ChangeType("+", typeof(TKey)), (TValue)Convert.ChangeType(Add, typeof(TValue)) },
        { (TKey)Convert.ChangeType("-", typeof(TKey)), (TValue)Convert.ChangeType(Subtract, typeof(TValue)) },
        { (TKey)Convert.ChangeType("*", typeof(TKey)), (TValue)Convert.ChangeType(Multiply, typeof(TValue)) },
        { (TKey)Convert.ChangeType("/", typeof(TKey)), (TValue)Convert.ChangeType(Divide, typeof(TValue)) }
    };

    private LineWriter WriteLine { init; get; }
    private LineReader ReadLine { init; get; }
    
    public Calculator()
    {
        ReadLine = new LineReader();
        WriteLine = new LineWriter();
    }
    
    public void calculate()
    {
        string equation = ReadLine.readLine();
        string[] equationParts = equation.Split(' ');
        TKey firstNumber = (TKey)Convert.ChangeType(equationParts[0], typeof(TKey));
        TKey secondNumber = (TKey)Convert.ChangeType(equationParts[2], typeof(TKey));
        TKey operation = (TKey)Convert.ChangeType(equationParts[1], typeof(TKey));
        TValue output = (TValue)Convert.ChangeType(MathematicalOperations[operation], typeof(TValue));
    }

    static TValue Add (TKey a, TKey b)
    {
        return (TValue)Convert.ChangeType((dynamic)a + (dynamic)b, typeof(TValue));
    }
    
    static TValue Subtract (TKey a, TKey b)
    {
        return (TValue)Convert.ChangeType((dynamic)a - (dynamic)b, typeof(TValue));
    }
    
    static TValue Multiply (TKey a, TKey b)
    {
        return (TValue)Convert.ChangeType((dynamic)a * (dynamic)b, typeof(TValue));
    }
    
    static TValue Divide (TKey a, TKey b)
    {
        return (TValue)Convert.ChangeType((dynamic)a / (dynamic)b, typeof(TValue));
    }
    
}
