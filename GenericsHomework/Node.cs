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
        Node<T> nextNode = new Node<T>(value);
        Next = nextNode;
    }


    public override string ToString()
    {
        return base.ToString();
    }
    
}
