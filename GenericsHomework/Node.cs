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
        if (Contains(value))
        {
            throw new DuplicateDataInArrayException(nameof(value));
        }
        
        Node<T> current = this;

        while (current.Next != current)
        {
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

        while (true)
        {
            if (current.Value.Equals(value))
            {
                return true;
            } 
            
            if (current.Next == current)
            {
                return false;
            }
            
            current = current.Next;
        }
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
        string holder = "{ ";
        Node<T> current = this;
        
        while (current.Next != current)
        {
            holder += current.Value + ", ";
            current = current.Next;
        }
        
        holder += current.Value + " }";
        return holder;
    }
    
}
