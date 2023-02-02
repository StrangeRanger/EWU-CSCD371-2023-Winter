namespace Logger;

public interface IEntity
{
    public Guid Id { get; init; }
    public FullName FullName { get; set; }
}