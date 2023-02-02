namespace Logger;

public record struct Employee : IEntity
{
    public Guid Id { get; init; }
    public string Name { get; set; }
}