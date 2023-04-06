using System;
namespace Logger;

public record class Book : Entity
{
    public Book(Guid id, FullName fullName, string title) : base(id)
    {
        Id = id;
        EntityFullName = fullName;
        Title = title;
    }

    private FullName EntityFullName { get; }
    public string Title { get; set; }

    /* Implemented implicitly, because there is no need to implicitly implement this property.
     * Additionally, "'Entity' in explicit interface declaration is not an interface", and it
     * wouldn't make sense to implement the the IEntity interface when we are extending Entity.
     */
    public override string Name
    {
        get {
            return EntityFullName.MiddleName is null
                       ? string.Format($"{EntityFullName.FirstName} {EntityFullName.LastName}")
                       : string.Format(
                             $"{EntityFullName.FirstName} {EntityFullName.MiddleName} {EntityFullName.LastName}");
        }
    }
}
