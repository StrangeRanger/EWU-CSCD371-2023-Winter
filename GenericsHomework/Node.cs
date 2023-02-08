namespace GenericsHomework;

public class Node<T>
{
    // Must be non-nullable.
    public Node(T value)
    {
        Value = value;
        Next = this;
    }
    
    public Node<T> Next { get; set; }
    
    public object Value { get; set; }

    public override string ToString()
    {
        return base.ToString();
    }
    
}
