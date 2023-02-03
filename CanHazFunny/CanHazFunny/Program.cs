namespace CanHazFunny;

class Program
{
    static void Main()
    {
        // Feel free to use your own setup here - this is just provided as an example
        // new Jester(new SomeReallyCoolOutputClass(), new SomeJokeServiceClass()).TellJoke();

        Jester joke = new Jester(new JokeOutput(), new JokeService());

        for (int i = 0; i < 10; i++)
        {
            joke.TellJoke();
        }
    }
}

