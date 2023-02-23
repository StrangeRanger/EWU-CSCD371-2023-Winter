namespace Calculate;

public class Program
{
    public static void Main()
    {
        ProgramBase program = new();
        Calculator calculator = new();

        program.WriteLine("Provide a calculation in the format: <number> <operator> <number> ");
        calculator.Calculate(program.WriteLine, program.ReadLine);
    }
}
