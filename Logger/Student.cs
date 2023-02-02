namespace Logger;

public record struct Student : IEntity
{
    public Guid Id { get; init; }
    public string Name { get; set; }
}