namespace Logger; 

public abstract class Entity : IEntity 
{
    protected Entity(Guid id, string name) {
        Id   = id;
        Name = name;
    }

    public Guid   Id   { get; init; }
    public string Name { get; set; }
}

