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
        return _jokeService.GetJoke();
    }
}
