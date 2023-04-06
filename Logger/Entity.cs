using System;
namespace Logger;

/**
 * The interface is implemented implicitly because it doesn't make sense otherwise.
 * Additionally, the compiler would throw an error if I tried to implement it implicitly
 */
public abstract record class Entity

(Guid Id) : IEntity
{
    public abstract string Name { get; }
}
