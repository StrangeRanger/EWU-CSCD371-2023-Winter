namespace Logger;

public record struct FullName(string FirstName, string? MiddleName, string LastName)
{
    /* Properties */
    public string FirstName { get; } = FirstName ?? throw new ArgumentNullException(nameof(FirstName));
    public string? MiddleName { get; } = MiddleName;
    public string LastName { get; } = LastName ?? throw new ArgumentNullException(nameof(LastName));
    
    /* Constructor. */
    public FullName(string firstName, string lastName) : this(firstName, null, lastName)
    {
        FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
    }
    public override string ToString()
    {
        if (MiddleName is null) {
            return $"{FirstName} {LastName}";
        } else {
            return $"{FirstName} {MiddleName} {LastName}";
        }
    }
}