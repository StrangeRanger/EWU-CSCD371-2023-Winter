namespace Logger;

public abstract class Entity : IEntity
{
    private Guid? _id;
    private string _name;

    Guid IEntity.Id { get; init; }

    string IEntity.Name
    {
        get => _name;
        set => _name = value;
    }
    
    public Entity(Guid id, string name)
    {
        _id = id;
        _name = name;
    }
}