using System;

namespace CanHazFunny;

public interface IJokeOutput
{
    public void outputJoke(String joke)
    {
        Console.Out.WriteLine(joke);
    }
    
    
}