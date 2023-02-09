using System;
namespace Logger;

/**
 * TODO: We weren't sure how to refactor the similarities of the Employee and Student class,
 * because as it stands, if we did that, we could just add everything into pretty much a
 * single file, which doesn't really make sense if, if both classes represent separate objects.
 * Please give use some input on what you think we should do
 */

public record class Employee : Entity
{
    /* ************************ [ Properties Part 1 ] ************************ */

    public FullName EntityFullName { get; set; }

    public string FirstName
    {
        get { return EntityFullName.FirstName; }
    }
    
    public string LastName
    {
        get { return EntityFullName.LastName; }
    }
    
    public string? MiddleName
    {
        get { return EntityFullName.MiddleName; }
    }
    
    /* ************************ [ Properties Part 2 ] ************************ */
    
    /* Implemented implicitly, because there is no need to implicitly implement this property.
     * Additionally, "'Entity' in explicit interface declaration is not an interface", and it
     * wouldn't make sense to implement the the IEntity interface when we are extending Entity.
     */
    public override string Name
    {
        get { return EntityFullName.ToString(); }
        set
        {
            string[] array = value.Split(' ');
            string firstName = array[0];
            string lastName = array[1];
            string middleName = array.Length > 2 ? array[2] : null;  // TODO: MAKE THIS BETTER
            EntityFullName = new FullName(firstName, lastName, middleName);
        }
    }
    
    /* ************************ [ Other ] ************************ */
    
    // Constructor.
    public Employee(Guid id, string fullName) : base(id)
    {
        Id = id;
        Name = fullName;
    }
}