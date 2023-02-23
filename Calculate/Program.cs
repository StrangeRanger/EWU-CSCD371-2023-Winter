namespace Calculate;

public class Program
{
    public static void Main()
    {
        ProgramBase program = new();
        Calculator calculator = new();
        
        calculator.Calculate(program.WriteLine, program.ReadLine);
    }
}
