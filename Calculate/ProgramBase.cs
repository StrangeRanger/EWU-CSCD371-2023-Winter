namespace Calculate;

public class ProgramBase
{
    public Action<string> WriteLine { get; init; } = s => Console.WriteLine(s);
    public Func<string?> ReadLine { get; init; } = () => Console.ReadLine();

    // ASSIGNMENT QUESTION: Is this empty constructor needed? The default constructor is created by
    //                      default during compilation, right? Wouldn't that make this constructor
    //                      redundant?
    public ProgramBase()
    {
    }
}
