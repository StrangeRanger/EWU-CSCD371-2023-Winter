using System;
namespace CanHazFunny;

public class JokeOutput : IJokeOutput
{
    public void PrintJoke(string output)
    {
        Console.WriteLine(output);
    }
}
