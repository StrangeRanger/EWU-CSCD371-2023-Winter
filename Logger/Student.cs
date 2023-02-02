namespace Logger;

public record struct Student : IEntity
{
    public Guid Id { get; init; }
    public FullName FullName { get; set; }
}