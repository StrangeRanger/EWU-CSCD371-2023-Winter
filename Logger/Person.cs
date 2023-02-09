using System;
namespace Logger;

public record class Person : Entity
{
    public Person(Guid id, FullName fullName) : base(id)
    {
        Id = id;
        EntityFullName = fullName;
    }
    
    private FullName EntityFullName { get; }
    public string FirstName
    {
        get { return EntityFullName.FirstName; }
    }
    public string? MiddleName
    {
        get { return EntityFullName.MiddleName; }
    }
    public string LastName
    {
        get { return EntityFullName.LastName; }
    }

    /* Implemented implicitly, because there is no need to implicitly implement this property.
     * Additionally, "'Entity' in explicit interface declaration is not an interface", and it
     * wouldn't make sense to implement the the IEntity interface when we are extending Entity.
     */
    public override string Name
    {
        get
        {
            return EntityFullName.MiddleName is null
                ? string.Format($"{EntityFullName.FirstName} {EntityFullName.LastName}")
                : string.Format($"{EntityFullName.FirstName} {EntityFullName.MiddleName} {EntityFullName.LastName}");
        }
    }
}
