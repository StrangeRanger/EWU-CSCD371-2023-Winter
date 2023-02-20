namespace Calculate;

public class ProgramMain
{
    public static void Main()
    {
        Program program = new();
        Calculator calculator = new();
        
        calculator.Calculate(program.WriteLine, program.ReadLine);

    }
}
