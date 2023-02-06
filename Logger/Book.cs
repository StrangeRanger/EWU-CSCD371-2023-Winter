namespace Logger;

public record class Book : Entity
{
    public string Author {
        get; set;
    }
    public override string Name {
        get; set;
    }

    public Book(string name, string author) : base(Guid.NewGuid(), name)
    {
        Name = name;
        Author = author;
    }
}