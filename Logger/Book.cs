namespace Logger;

public record struct Book : IEntity
{
    public Guid Id { get; init; }
    public FullName FullName { get; set; }
}