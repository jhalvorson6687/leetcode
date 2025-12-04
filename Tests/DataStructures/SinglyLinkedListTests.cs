using CSharp_leetcode.DataStructures.LinkedList;
using Xunit;

namespace CSharp_leetcode.Tests.DataStructures;

public class SinglyLinkedListTests
{
    [Fact]
    public void Constructor_CreatesEmptyList()
    {
        // Arrange & Act
        var list = new SinglyLinkedList<int>();

        // Assert
        Assert.Null(list.Head);
        Assert.Equal(0, list.Count);
    }

    [Fact]
    public void InsertAtHead_EmptyList_AddsNode()
    {
        // Arrange
        var list = new SinglyLinkedList<int>();

        // Act
        list.InsertAtHead(10);

        // Assert
        Assert.NotNull(list.Head);
        Assert.Equal(10, list.Head.Data);
        Assert.Null(list.Head.Next);
        Assert.Equal(1, list.Count);
    }

    [Fact]
    public void InsertAtHead_MultipleNodes_InsertsInCorrectOrder()
    {
        // Arrange
        var list = new SinglyLinkedList<int>();

        // Act
        list.InsertAtHead(10);
        list.InsertAtHead(20);
        list.InsertAtHead(30);

        // Assert
        Assert.Equal(30, list.Head!.Data);
        Assert.Equal(20, list.Head.Next!.Data);
        Assert.Equal(10, list.Head.Next.Next!.Data);
        Assert.Equal(3, list.Count);
    }

    [Fact]
    public void InsertAtTail_EmptyList_AddsNode()
    {
        // Arrange
        var list = new SinglyLinkedList<int>();

        // Act
        list.InsertAtTail(10);

        // Assert
        Assert.NotNull(list.Head);
        Assert.Equal(10, list.Head.Data);
        Assert.Equal(1, list.Count);
    }

    [Fact]
    public void InsertAtTail_MultipleNodes_InsertsInCorrectOrder()
    {
        // Arrange
        var list = new SinglyLinkedList<int>();

        // Act
        list.InsertAtTail(10);
        list.InsertAtTail(20);
        list.InsertAtTail(30);

        // Assert
        Assert.Equal(10, list.Head!.Data);
        Assert.Equal(20, list.Head.Next!.Data);
        Assert.Equal(30, list.Head.Next.Next!.Data);
        Assert.Equal(3, list.Count);
    }

    [Fact]
    public void InsertAtPosition_ValidPosition_InsertsNode()
    {
        // Arrange
        var list = new SinglyLinkedList<int>();
        list.InsertAtTail(10);
        list.InsertAtTail(30);

        // Act
        list.InsertAtPosition(20, 1);

        // Assert
        Assert.Equal(10, list.Head!.Data);
        Assert.Equal(20, list.Head.Next!.Data);
        Assert.Equal(30, list.Head.Next.Next!.Data);
        Assert.Equal(3, list.Count);
    }

    [Fact]
    public void Delete_ExistingNode_RemovesNode()
    {
        // Arrange
        var list = new SinglyLinkedList<int>();
        list.InsertAtTail(10);
        list.InsertAtTail(20);
        list.InsertAtTail(30);

        // Act
        var result = list.Delete(20);

        // Assert
        Assert.True(result);
        Assert.Equal(10, list.Head!.Data);
        Assert.Equal(30, list.Head.Next!.Data);
        Assert.Equal(2, list.Count);
    }

    [Fact]
    public void Delete_NonExistingNode_ReturnsFalse()
    {
        // Arrange
        var list = new SinglyLinkedList<int>();
        list.InsertAtTail(10);
        list.InsertAtTail(20);

        // Act
        var result = list.Delete(99);

        // Assert
        Assert.False(result);
        Assert.Equal(2, list.Count);
    }

    [Fact]
    public void DeleteAtPosition_EmptyList_ThrowsException()
    {
        // Arrange
        var list = new SinglyLinkedList<int>();

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => list.DeleteAtPosition(0));
    }

    [Fact]
    public void DeleteAtPosition_NegativePosition_ThrowsException()
    {
        // Arrange
        var list = new SinglyLinkedList<int>();
        list.InsertAtTail(10);

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => list.DeleteAtPosition(-1));
    }

    [Fact]
    public void DeleteAtPosition_PositionTooLarge_ThrowsException()
    {
        // Arrange
        var list = new SinglyLinkedList<int>();
        list.InsertAtTail(10);
        list.InsertAtTail(20);

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => list.DeleteAtPosition(5));
    }

    [Fact]
    public void DeleteAtPosition_DeleteHead_RemovesFirstNode()
    {
        // Arrange
        var list = new SinglyLinkedList<int>();
        list.InsertAtTail(10);
        list.InsertAtTail(20);
        list.InsertAtTail(30);

        // Act
        var result = list.DeleteAtPosition(0);

        // Assert
        Assert.True(result);
        Assert.Equal(20, list.Head!.Data);
        Assert.Equal(30, list.Head.Next!.Data);
        Assert.Equal(2, list.Count);
    }

    [Fact]
    public void DeleteAtPosition_DeleteMiddle_RemovesCorrectNode()
    {
        // Arrange
        var list = new SinglyLinkedList<int>();
        list.InsertAtTail(10);
        list.InsertAtTail(20);
        list.InsertAtTail(30);

        // Act
        var result = list.DeleteAtPosition(1);

        // Assert
        Assert.True(result);
        Assert.Equal(10, list.Head!.Data);
        Assert.Equal(30, list.Head.Next!.Data);
        Assert.Equal(2, list.Count);
    }

    [Fact]
    public void DeleteAtPosition_DeleteTail_RemovesLastNode()
    {
        // Arrange
        var list = new SinglyLinkedList<int>();
        list.InsertAtTail(10);
        list.InsertAtTail(20);
        list.InsertAtTail(30);

        // Act
        var result = list.DeleteAtPosition(2);

        // Assert
        Assert.True(result);
        Assert.Equal(10, list.Head!.Data);
        Assert.Equal(20, list.Head.Next!.Data);
        Assert.Null(list.Head.Next.Next);
        Assert.Equal(2, list.Count);
    }

    [Fact]
    public void DeleteAtPosition_SingleNode_EmptiesList()
    {
        // Arrange
        var list = new SinglyLinkedList<int>();
        list.InsertAtTail(10);

        // Act
        var result = list.DeleteAtPosition(0);

        // Assert
        Assert.True(result);
        Assert.Null(list.Head);
        Assert.Equal(0, list.Count);
    }

    [Fact]
    public void Search_ExistingNode_ReturnsTrue()
    {
        // Arrange
        var list = new SinglyLinkedList<int>();
        list.InsertAtTail(10);
        list.InsertAtTail(20);
        list.InsertAtTail(30);

        // Act
        var result = list.Search(20);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Search_NonExistingNode_ReturnsFalse()
    {
        // Arrange
        var list = new SinglyLinkedList<int>();
        list.InsertAtTail(10);
        list.InsertAtTail(20);

        // Act
        var result = list.Search(99);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Reverse_ReversesList()
    {
        // Arrange
        var list = new SinglyLinkedList<int>();
        list.InsertAtTail(10);
        list.InsertAtTail(20);
        list.InsertAtTail(30);

        // Act
        list.Reverse();

        // Assert
        Assert.Equal(30, list.Head!.Data);
        Assert.Equal(20, list.Head.Next!.Data);
        Assert.Equal(10, list.Head.Next.Next!.Data);
        Assert.Equal(3, list.Count);
    }

    [Fact]
    public void GetAt_ValidPosition_ReturnsData()
    {
        // Arrange
        var list = new SinglyLinkedList<int>();
        list.InsertAtTail(10);
        list.InsertAtTail(20);
        list.InsertAtTail(30);

        // Act
        var result = list.GetAt(1);

        // Assert
        Assert.Equal(20, result);
    }

    [Fact]
    public void ToArray_ConvertsListToArray()
    {
        // Arrange
        var list = new SinglyLinkedList<int>();
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
        var list = new SinglyLinkedList<int>();
        list.InsertAtTail(10);
        list.InsertAtTail(20);

        // Act
        list.Clear();

        // Assert
        Assert.Null(list.Head);
        Assert.Equal(0, list.Count);
    }
}
