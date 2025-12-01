# Linked List

A linked list is a linear data structure where elements are stored in nodes, and each node points to the next node in the sequence.

## Implementations

- `SinglyLinkedList.cs` - Each node has one pointer to the next node
- `DoublyLinkedList.cs` - Each node has pointers to both next and previous nodes

## Time Complexity

| Operation      | Singly Linked List | Doubly Linked List |
| -------------- | ------------------ | ------------------ |
| Access         | O(n)               | O(n)               |
| Search         | O(n)               | O(n)               |
| Insert at head | O(1)               | O(1)               |
| Insert at tail | O(n) or O(1)\*     | O(1)               |
| Delete at head | O(1)               | O(1)               |
| Delete at tail | O(n)               | O(1)               |

\*O(1) if you maintain a tail pointer

## Space Complexity

- Singly: O(n) - one pointer per node
- Doubly: O(n) - two pointers per node

## Use Cases

- Implementing stacks and queues
- Undo functionality in applications
- Browser history navigation
- Music playlist management

## Related LeetCode Problems

- #206 - Reverse Linked List
- #21 - Merge Two Sorted Lists
- #141 - Linked List Cycle
- #2 - Add Two Numbers
- #19 - Remove Nth Node From End
