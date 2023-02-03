namespace Logger;

public record struct Student : IEntity
{
    public Student(Guid? id, string? firstMiddleLastName)
    {
        Id = id ?? throw new ArgumentNullException(nameof(id));;
        Name = firstMiddleLastName ?? throw new ArgumentNullException(nameof(firstMiddleLastName));
    }
    public Guid Id { get; init; }
    private FullName? EntityFullName { get; set; }

    public string firstName
    {
        get => EntityFullName!.FirstName;
    }
    
    public string lastName
    {
        get => EntityFullName!.LastName;
    }
    
    public string middleName
    {
        get => EntityFullName!.MiddleName ?? "";
    }
    
    public string Name
    {
        get => EntityFullName!.ToString();
        set
        {
            string firstName = value.Substring(0, value.IndexOf(' '));
            string lastName = value.Substring(value.LastIndexOf(' ') + 1);
            string middleName = value.Substring(value.IndexOf(' ') + 1, value.LastIndexOf(' '));
            EntityFullName = new(firstName, lastName, middleName);
        }
    }
    
    public string NameAndId
    {
        get => EntityFullName!.ToString()+Id.ToString();
    }
}