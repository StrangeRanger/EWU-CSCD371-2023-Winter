namespace Logger;

public record FullName
{
    public FullName(string firstName, string middleName, string lastName)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }
    public string FirstName { get; init; }
    public string MiddleName { get; init; }
    public string LastName { get; init; }
}