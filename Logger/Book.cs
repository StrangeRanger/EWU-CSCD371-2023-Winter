namespace Logger;

public record struct Book : IEntity
{
    public Book(Guid? id, string? name, string? author)
    {
        Id = id ?? throw new ArgumentNullException(nameof(id));
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Author = author ?? throw new ArgumentNullException(nameof(author));
    }
    public Guid Id { get; init; }
    public string Name { get; set; }
    public string Author { get; set; }
}