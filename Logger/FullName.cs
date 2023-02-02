namespace Logger;

public record class FullName
(string FirstName, string LastName, string? MiddleName = null)
{
    /* Properties */
    public string FirstName {
        get;
    } = FirstName ?? throw new ArgumentNullException(nameof(FirstName));
    public string LastName {
        get;
    } = LastName ?? throw new ArgumentNullException(nameof(LastName));
    public string ? MiddleName { get; } = MiddleName;

    public override string ToString()
    {
        return MiddleName is null ? $"{FirstName} {LastName}"
                                  : $"{FirstName} {MiddleName} {LastName}";
    }
}
