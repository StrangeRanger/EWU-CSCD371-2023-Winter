namespace Logger;

public record struct Employee : IEntity
{
    public Guid Id { get; init; }
    public FullName FullName { get; set; }
}