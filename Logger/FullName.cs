using System;
namespace Logger;

/**
 * We chose to make this record struct, because with all the inheritance, it'd be more ideal
 * that we create a new object, rather than accidentally refer to an existing object...
 *
 * We made all variables in this class immutable, because we want to make sure that the values
 * of the variables are not changed after the object is created.
 */
public record struct FullName

(string FirstName, string LastName, string? MiddleName = null)
{
    public string FirstName {
        get;
    } = FirstName ?? throw new ArgumentNullException(nameof(FirstName));
    public string LastName { get; } = LastName ?? throw new ArgumentNullException(nameof(LastName));
    public string ? MiddleName { get; } = MiddleName;

    public override string ToString() =>
        MiddleName == null ? $"{FirstName} {LastName}" : $"{FirstName} {MiddleName} {LastName}";
}
