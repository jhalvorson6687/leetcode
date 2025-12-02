namespace CSharp_leetcode.DataStructures.LinkedList;

/// <summary>
/// Node for a singly linked list
/// </summary>
/// <typeparam name="T">Type of data stored in the node</typeparam>
public class SinglyLinkedListNode<T>(T data)
{
    public T Data { get; set; } = data;
    public SinglyLinkedListNode<T>? Next { get; set; } = null;
}

/// <summary>
/// Singly Linked List implementation
/// Each node points to the next node in the sequence
/// </summary>
/// <typeparam name="T">Type of data stored in the list</typeparam>
public class SinglyLinkedList<T>
{
    public SinglyLinkedListNode<T>? Head { get; private set; }
    public int Count { get; private set; }

    public SinglyLinkedList()
    {
        Head = null;
        Count = 0;
    }

    /// <summary>
    /// Insert a new node at the head of the list
    /// Time Complexity: O(1)
    /// </summary>
    public void InsertAtHead(T data)
    {
        var newNode = new SinglyLinkedListNode<T>(data)
        {
            Next = Head
        };
        Head = newNode;
        Count++;
    }

    /// <summary>
    /// Insert a new node at the tail of the list
    /// Time Complexity: O(n)
    /// </summary>
    public void InsertAtTail(T data)
    {
        var newNode = new SinglyLinkedListNode<T>(data);
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        Count++;
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
    /// Display the list (for debugging)
    /// </summary>
    public void Display()
    {
        var current = Head;
        while (current != null)
        {
            Console.Write($"{current.Data} -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}
