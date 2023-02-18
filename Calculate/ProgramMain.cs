namespace Calculate;

public class ProgramMain
{
    public static void Main()
    {
        Program program = new();
        Calculator.TryCalculate(program.WriteLine, program.ReadLine);

    }
}
