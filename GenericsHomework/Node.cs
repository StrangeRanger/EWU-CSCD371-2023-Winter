using System;
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
        Node<T> current = this;
        
        while (current.Next != current)
        {
            if (current.Value.Equals(value)) {
                throw new DuplicateDataInArrayException(nameof(value));
            }
            
            current = current.Next;
        }
        
        current.Next = new Node<T>(value);
    }

    public void Clear()
    {
        Next = this;
    }
    
    public bool Contains(T value)
    {
        Node<T> current = this;
        
        while (current.Next != current)
        {
            if (current.Value.Equals(value))
            {
                return true;
            }
            
            current = current.Next;
        }

        return false;
    }

    // public int NumberOfItems()
    // {
    //     Node<T> current = this;
    //     int count = 1;
    //     
    //     while (current.Next != current) 
    //     {
    //         current = current.Next;
    //         count++;
    //     }
    //
    //     return count;
    // }

    public override string ToString()
    {
        return base.ToString();
    }
    
}
