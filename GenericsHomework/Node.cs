namespace GenericsHomework;

public class Node<T>
{
    // Must be non-nullable.
    public Node(T value)
    {
        Value = value;
        Next = this;
    }
    
    public Node<T> Next { get; private set; }
    public object Value { get; set; }

    public void Append(T value)
    {
        var current = this;
        while (current.Next != current)
        {
            current = current.Next.Next;
        }
        current.Next = new Node<T>(value);
    }


    public override string ToString()
    {
        return base.ToString();
    }
    
}
