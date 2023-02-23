namespace Calculate;

public class Program
{
    public Action<string> WriteLine { get; init; } = Console.WriteLine;
    public Func<string?> ReadLine { get; init; } = Console.ReadLine;

    // ASSIGNMENT QUESTION: Is this empty constructor needed? The default constructor is created by
    //                      default during compilation, right? Wouldn't that make this constructor
    //                      redundant?
    public Program()
    { }
}
