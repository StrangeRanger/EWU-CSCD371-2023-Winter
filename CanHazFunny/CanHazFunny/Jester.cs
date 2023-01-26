using System;
namespace CanHazFunny;

public class Jester : IJokeOutput, IJokeService
{
    private JokeService _jokeService = new();

    public void TellJoke()
    {
        PrintJoke(_jokeService.GetJoke());
    }

    public void PrintJoke(string output)
    {
        Console.Out.WriteLine(output);
        // throw new NotImplementedException();
    }

    public string GetJoke()
    {
        return GetJoke();
    }
}
