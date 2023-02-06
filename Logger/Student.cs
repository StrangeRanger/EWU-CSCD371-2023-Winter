namespace Logger;

public record class Student : Entity
{
    /* ##################### [ Properties Part 1 ] ##################### */

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

    /* ##################### [ Properties Part 2 ] ##################### */
    
    public override string Name
    {
        get { return EntityFullName.ToString(); }
        set
        {
            string[] array = value.Split(' ');
            string firstName = array[0];
            string lastName = array[1];
            string middleName = array.Length > 2 ? array[2] : null; // TODO: MAKE THIS BETTER
            EntityFullName = new FullName(firstName, lastName, middleName);
        }
    }
    
    public Student(Guid id, string fullName) : base(id)
    {
        Id = id;
        Name = fullName;
    }
}