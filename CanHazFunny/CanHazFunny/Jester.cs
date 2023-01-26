namespace CanHazFunny;

public class Jester : IJokeOutput, IJokeService
{
    private JokeService _jokeService = new();
    private JokeOutput  _jokeOutput  = new();

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
