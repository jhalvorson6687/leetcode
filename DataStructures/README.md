# Data Structures

Implementations of fundamental data structures built from scratch for learning purposes.

## Available Structures

### Linear Data Structures

- **Array** - Dynamic array implementation with common operations
- **LinkedList** - Singly and doubly linked list implementations
- **Stack** - LIFO data structure
- **Queue** - FIFO data structure

### Tree Structures

- **BinaryTree** - Binary tree and binary search tree implementations
- **Heap** - Min heap and max heap implementations

### Hash-Based Structures

- **HashTable** - Custom hash table implementation

### Graph Structures

- **Graph** - Adjacency list and adjacency matrix representations

## Implementation Guidelines

Each data structure folder contains:

- **Implementation file** (e.g., `SinglyLinkedList.cs`)
- **Test file** (e.g., `SinglyLinkedListTests.cs`)
- **README.md** with:
  - How it works
  - Time complexity analysis
  - Space complexity analysis
  - Common operations
  - Use cases
  - Related LeetCode problems

## Testing

Run tests for all data structures:

```bash
dotnet test --filter FullyQualifiedName~DataStructures
```

Run tests for a specific structure:

```bash
dotnet test --filter LinkedList
```
