namespace Logger; 

public abstract class Entity : IEntity 
{
    protected Entity(Guid id, string name) {
        Id   = id;
        Name = name;
    }

    public Guid     Id       { get; init; }
    public FullName FullName { get; set; }
    public string Name { get; set; }
}

