using System;
namespace CanHazFunny;

public class Jester
{
    private IJokeOutput? _JokeOutput;
    public IJokeOutput JokeOutput
    {
        get {
            return _JokeOutput!;
        }
        set {
            _JokeOutput = value ?? throw new ArgumentNullException(nameof(value));
        }
    }

    private IJokeService? _JokeService;
    public IJokeService JokeService
    {
        get {
            return _JokeService!;
        }
        set {
            _JokeService = value ?? throw new ArgumentNullException(nameof(value));
        }
    }

    /** Constructor. */
    public Jester(IJokeOutput jokeOutput, IJokeService jokeService)
    {
        JokeOutput  = jokeOutput;
        JokeService = jokeService;
    }

    public void TellJoke()
    {
        string joke;

        do {
            joke = JokeService.GetJoke();
        } while (joke.Contains("Chuck Norris"));

        JokeOutput.PrintJoke(joke);
    }
}
