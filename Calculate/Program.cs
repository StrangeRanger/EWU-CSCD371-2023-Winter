namespace Calculate;

public class Program
{
    public Action<string> WriteLine { get; init; } = (string s) => Console.WriteLine(s);
    public Func<string?> ReadLine { get; init; } = () => Console.ReadLine();
}
