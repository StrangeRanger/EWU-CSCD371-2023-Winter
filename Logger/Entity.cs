using System;
namespace Logger;

/**
 * The interface is implemented implicitly because it doesn't make sense otherwise.
 * Additionally, the compiler would throw an error if I tried to implement it implicitly
 */
public abstract record class Entity : IEntity
{
    public Guid Id { get; init; }
    public abstract string Name { get; set; }

    // Constructor.
    protected Entity(Guid id, string? name = null)
    {
        Id = id;
    }
}

