using System;
namespace CanHazFunny; 

public class Jester : IJokeOutput, IJokeService {
    
    public void TellJoke() {
        JokeService jokeService = new();
        
    }

    public void PrintJoke(string output) {
        throw new NotImplementedException();
    }

    public string GetJoke() {
        throw new NotImplementedException();
    }
}
