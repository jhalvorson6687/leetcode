namespace CSharp_leetcode.DataStructures.LinkedList;

/// <summary>
/// Node for a doubly linked list
/// </summary>
/// <typeparam name="T">Type of data stored in the node</typeparam>
public class DoublyLinkedListNode<T>(T data)
{
    public T Data { get; set; } = data;
    public DoublyLinkedListNode<T>? Next { get; set; } = null;
    public DoublyLinkedListNode<T>? Previous { get; set; } = null;
}

/// <summary>
/// Doubly Linked List implementation
/// Each node has pointers to both the next and previous nodes
/// </summary>
/// <typeparam name="T">Type of data stored in the list</typeparam>
public class DoublyLinkedList<T>
{
    public DoublyLinkedListNode<T>? Head { get; private set; }
    public DoublyLinkedListNode<T>? Tail { get; private set; }
    public int Count { get; private set; }

    public DoublyLinkedList()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }

    /// <summary>
    /// Insert a new node at the head of the list
    /// Time Complexity: O(1)
    /// </summary>
    public void InsertAtHead(T data)
    {
        // TODO: Implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Insert a new node at the tail of the list
    /// Time Complexity: O(1)
    /// </summary>
    public void InsertAtTail(T data)
    {
        // TODO: Implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Insert a new node at a specific position (0-indexed)
    /// Time Complexity: O(n)
    /// </summary>
    public void InsertAtPosition(T data, int position)
    {
        // TODO: Implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Delete the first occurrence of a node with the given data
    /// Time Complexity: O(n)
    /// </summary>
    public bool Delete(T data)
    {
        // TODO: Implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Delete the node at a specific position (0-indexed)
    /// Time Complexity: O(n)
    /// </summary>
    public bool DeleteAtPosition(int position)
    {
        // TODO: Implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Delete the head node
    /// Time Complexity: O(1)
    /// </summary>
    public bool DeleteHead()
    {
        // TODO: Implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Delete the tail node
    /// Time Complexity: O(1)
    /// </summary>
    public bool DeleteTail()
    {
        // TODO: Implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Search for a node with the given data
    /// Time Complexity: O(n)
    /// </summary>
    public bool Search(T data)
    {
        // TODO: Implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Reverse the linked list
    /// Time Complexity: O(n)
    /// </summary>
    public void Reverse()
    {
        // TODO: Implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get the data at a specific position (0-indexed)
    /// Time Complexity: O(n)
    /// </summary>
    public T GetAt(int position)
    {
        // TODO: Implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Clear the entire list
    /// Time Complexity: O(1)
    /// </summary>
    public void Clear()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }

    /// <summary>
    /// Convert the list to an array
    /// Time Complexity: O(n)
    /// </summary>
    public T[] ToArray()
    {
        // TODO: Implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Display the list forward (for debugging)
    /// </summary>
    public void DisplayForward()
    {
        var current = Head;
        Console.Write("null <- ");
        while (current != null)
        {
            Console.Write($"{current.Data}");
            if (current.Next != null)
                Console.Write(" <-> ");
            current = current.Next;
        }
        Console.WriteLine(" -> null");
    }

    /// <summary>
    /// Display the list backward (for debugging)
    /// </summary>
    public void DisplayBackward()
    {
        var current = Tail;
        Console.Write("null <- ");
        while (current != null)
        {
            Console.Write($"{current.Data}");
            if (current.Previous != null)
                Console.Write(" <-> ");
            current = current.Previous;
        }
        Console.WriteLine(" -> null");
    }
}
