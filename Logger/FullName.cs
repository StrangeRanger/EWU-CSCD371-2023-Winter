namespace Logger;

public record struct FullName(string FirstName, string LastName, string? MiddleName = null)
{
    /* Properties */
    public string FirstName { get; } = FirstName ?? throw new ArgumentNullException(nameof(FirstName));
    public string ? MiddleName { get; } = MiddleName;
    public string LastName { get; } = LastName ?? throw new ArgumentNullException(nameof(LastName));

    public override string ToString()
    {
        if (MiddleName is null) {
            return $"{FirstName} {LastName}";
        } else {
            return $"{FirstName} {MiddleName} {LastName}";
        }
    }
}

