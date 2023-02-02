namespace Logger;

public record struct FullName
{
    public FullName(string firstName, string? middleName, string lastName)
    {
        FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        MiddleName = middleName ?? throw new ArgumentNullException(nameof(middleName));
        LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
    }
    public FullName(string firstName, string lastName)
    {
        FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
    }
    public override string ToString()
    {
        if (MiddleName is null)
        {
            return $"{FirstName} {LastName}";
        }
        else
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }
    }
    public string FirstName { get; init; }
    public string? MiddleName { get; set; }
    public string LastName { get; init; }
}