namespace GenericsHomework;

public class Node<T>
{
    // Must be non-nullable.
    public Node(T value)
    {
        Value = value !;
        Next = this;
    }

    public Node<T> Next { get; private set; }
    public T Value { get; set; }

    public void Append(T value)
    {
        if (Exists(value))
        {
            throw new DuplicateDataInArrayException(nameof(value));
        }

        Node<T> current = this;

        while (current.Next != current) { current = current.Next; }

        current.Next = new Node<T>(value);
    }

    /**
     * When we clear the list, specifying that the Next property for the first node in the list now
     * refers to itself, all previous references to the other nodes in the list will be dropped, and
     * the garbage collector will be able to reclaim the memory used by them.
     */
    public void Clear()
    {
        Next = this;
    }

    public bool Exists(T value)
    {
        Node<T> current = this;

        while (true)
        {
            if (current.Value != null && current.Value.Equals(value)) { return true; }
            if (current.Next == current) { return false; }

            current = current.Next;
        }
    }

    // NOTE: Please pay no mind to this method. I was doing some testing and would like to
    //       keep it here, for future reference.
    /*
    public int NumberOfItemsInArray()
    {
        Node<T> current = this;
        int count = 1;

        while (current.Next != current)
        {
            current = current.Next;
            count++;
        }

        return count;
    }
    */

    public override string ToString()
    {
        return Value is not null ? Value.ToString()! : string.Empty;
    }

}
