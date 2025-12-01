using CSharp_leetcode.DataStructures.LinkedList;
using Xunit;

namespace CSharp_leetcode.Tests.DataStructures;

public class DoublyLinkedListTests
{
    [Fact]
    public void Constructor_CreatesEmptyList()
    {
        // Arrange & Act
        var list = new DoublyLinkedList<int>();

        // Assert
        Assert.Null(list.Head);
        Assert.Null(list.Tail);
        Assert.Equal(0, list.Count);
    }

    [Fact]
    public void InsertAtHead_EmptyList_AddsNode()
    {
        // Arrange
        var list = new DoublyLinkedList<int>();

        // Act
        list.InsertAtHead(10);

        // Assert
        Assert.NotNull(list.Head);
        Assert.NotNull(list.Tail);
        Assert.Equal(10, list.Head.Data);
        Assert.Equal(10, list.Tail.Data);
        Assert.Equal(1, list.Count);
    }

    [Fact]
    public void InsertAtHead_MultipleNodes_InsertsInCorrectOrder()
    {
        // Arrange
        var list = new DoublyLinkedList<int>();

        // Act
        list.InsertAtHead(10);
        list.InsertAtHead(20);
        list.InsertAtHead(30);

        // Assert
        Assert.Equal(30, list.Head!.Data);
        Assert.Equal(20, list.Head.Next!.Data);
        Assert.Equal(10, list.Tail!.Data);
        Assert.Equal(3, list.Count);
    }

    [Fact]
    public void InsertAtTail_EmptyList_AddsNode()
    {
        // Arrange
        var list = new DoublyLinkedList<int>();

        // Act
        list.InsertAtTail(10);

        // Assert
        Assert.NotNull(list.Head);
        Assert.NotNull(list.Tail);
        Assert.Equal(10, list.Head.Data);
        Assert.Equal(10, list.Tail.Data);
        Assert.Equal(1, list.Count);
    }

    [Fact]
    public void InsertAtTail_MultipleNodes_InsertsInCorrectOrder()
    {
        // Arrange
        var list = new DoublyLinkedList<int>();

        // Act
        list.InsertAtTail(10);
        list.InsertAtTail(20);
        list.InsertAtTail(30);

        // Assert
        Assert.Equal(10, list.Head!.Data);
        Assert.Equal(30, list.Tail!.Data);
        Assert.Equal(20, list.Tail.Previous!.Data);
        Assert.Equal(3, list.Count);
    }

    [Fact]
    public void Delete_ExistingNode_RemovesNodeAndUpdatesPreviousNext()
    {
        // Arrange
        var list = new DoublyLinkedList<int>();
        list.InsertAtTail(10);
        list.InsertAtTail(20);
        list.InsertAtTail(30);

        // Act
        var result = list.Delete(20);

        // Assert
        Assert.True(result);
        Assert.Equal(10, list.Head!.Data);
        Assert.Equal(30, list.Tail!.Data);
        Assert.Equal(30, list.Head.Next!.Data);
        Assert.Equal(10, list.Tail.Previous!.Data);
        Assert.Equal(2, list.Count);
    }

    [Fact]
    public void DeleteHead_RemovesHeadNode()
    {
        // Arrange
        var list = new DoublyLinkedList<int>();
        list.InsertAtTail(10);
        list.InsertAtTail(20);
        list.InsertAtTail(30);

        // Act
        var result = list.DeleteHead();

        // Assert
        Assert.True(result);
        Assert.Equal(20, list.Head!.Data);
        Assert.Null(list.Head.Previous);
        Assert.Equal(2, list.Count);
    }

    [Fact]
    public void DeleteTail_RemovesTailNode()
    {
        // Arrange
        var list = new DoublyLinkedList<int>();
        list.InsertAtTail(10);
        list.InsertAtTail(20);
        list.InsertAtTail(30);

        // Act
        var result = list.DeleteTail();

        // Assert
        Assert.True(result);
        Assert.Equal(20, list.Tail!.Data);
        Assert.Null(list.Tail.Next);
        Assert.Equal(2, list.Count);
    }

    [Fact]
    public void Search_ExistingNode_ReturnsTrue()
    {
        // Arrange
        var list = new DoublyLinkedList<int>();
        list.InsertAtTail(10);
        list.InsertAtTail(20);
        list.InsertAtTail(30);

        // Act
        var result = list.Search(20);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Reverse_ReversesList()
    {
        // Arrange
        var list = new DoublyLinkedList<int>();
        list.InsertAtTail(10);
        list.InsertAtTail(20);
        list.InsertAtTail(30);

        // Act
        list.Reverse();

        // Assert
        Assert.Equal(30, list.Head!.Data);
        Assert.Equal(10, list.Tail!.Data);
        Assert.Equal(20, list.Head.Next!.Data);
        Assert.Equal(3, list.Count);
    }

    [Fact]
    public void ToArray_ConvertsListToArray()
    {
        // Arrange
        var list = new DoublyLinkedList<int>();
        list.InsertAtTail(10);
        list.InsertAtTail(20);
        list.InsertAtTail(30);

        // Act
        var array = list.ToArray();

        // Assert
        Assert.Equal(new[] { 10, 20, 30 }, array);
    }

    [Fact]
    public void Clear_EmptiesList()
    {
        // Arrange
        var list = new DoublyLinkedList<int>();
        list.InsertAtTail(10);
        list.InsertAtTail(20);

        // Act
        list.Clear();

        // Assert
        Assert.Null(list.Head);
        Assert.Null(list.Tail);
        Assert.Equal(0, list.Count);
    }
}
