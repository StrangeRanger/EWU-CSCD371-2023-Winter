namespace Logger;

public record class Student(Guid Id) : Entity(Id)
{
    private FullName _FullName;
    public FullName FullName { get => _FullName; set => _FullName = value; }

    public override string Name
    {
        get { return FullName.ToString(); }
        set
        {
            string firstName = value.Substring(0, value.IndexOf(' '));
            string lastName = value.Substring(value.LastIndexOf(' ') + 1);
            string middleName = value.Substring(value.IndexOf(' ') + 1, value.LastIndexOf(' '));
            FullName = new(firstName, lastName, middleName);
        }
    }
}