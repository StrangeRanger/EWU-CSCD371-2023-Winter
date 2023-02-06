namespace Logger;

public record class Employee : Entity
{
    private FullName? EntityFullName {
        get; set;
    }
    public Employee(Guid id, string firstMiddleLastName) : base(id)
    {
        Id = id;
        Name = firstMiddleLastName;
    }

    public override string Name
    {
        get => EntityFullName.ToString();
        set
        {
            string firstName = value.Substring(0, value.IndexOf(' '));
            string lastName = value.Substring(value.LastIndexOf(' ') + 1);
            string middleName = value.Substring(value.IndexOf(' ') + 1, value.LastIndexOf(' '));
            EntityFullName = new(firstName, lastName, middleName);
        }
    }
}