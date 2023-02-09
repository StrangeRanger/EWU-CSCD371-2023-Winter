using System;
namespace Logger;

public record class Book(string Name, string Author) : Entity(Guid.NewGuid(), Name)
{
    public string Author { get; set; } = Author;

    /* Implemented implicitly, because there is no need to implicitly implement this property.
     * Additionally, "'Entity' in explicit interface declaration is not an interface", and it
     * wouldn't make sense to implement the the IEntity interface when we are extending Entity.
     */
    public sealed override string Name { get; set; } = Name;

    public override string ToString() => $"{Name} by {Author}";
}