namespace Calculate;

public class Program
{
    private  Calculator.WriteDelegate WriteLine { get; init; }
    private Calculator.ReadDelegate ReadLine { get; init; }
    
    public Program()
    {
        WriteLine = Calculator.WriteLine;
        ReadLine = Calculator.ReadLine;
    }
    
    public void run()
    {
        Calculator calculator = new();
        calculator.TryCalculate(WriteLine, ReadLine);
    }

}
