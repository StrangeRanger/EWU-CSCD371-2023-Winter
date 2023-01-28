using System;
namespace CanHazFunny;

public class Jester : IJokeOutput, IJokeService
{
    private JokeOutput  _jokeOutput;
    private JokeService _jokeService;
    

    public Jester()
    {
        _jokeOutput  = new JokeOutput();
        _jokeService = new JokeService();

        if (_jokeOutput is null) { throw new ArgumentNullException(nameof(_jokeOutput)); }
        if (_jokeService is null) { throw new ArgumentNullException(nameof(_jokeService)); }
    }

    public void TellJoke()
    {
        string joke = GetJoke();
        PrintJoke(joke);
    }

    public void PrintJoke(string output)
    {
        _jokeOutput.PrintJoke(output);
    }

    public string GetJoke()
    {
        string joke;
        do {
            joke = _jokeService.GetJoke();
        } while (joke.Contains("Chuck Norris"));
        return joke;
    }
}
