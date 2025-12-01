# Algorithms

Implementations of fundamental algorithms built from scratch for learning purposes.

## Available Algorithms

### Sorting Algorithms

- **Bubble Sort** - O(n²) comparison-based sorting
- **Selection Sort** - O(n²) comparison-based sorting
- **Insertion Sort** - O(n²) comparison-based sorting
- **Merge Sort** - O(n log n) divide and conquer
- **Quick Sort** - O(n log n) average case
- **Heap Sort** - O(n log n) using heap data structure

### Searching Algorithms

- **Linear Search** - O(n) sequential search
- **Binary Search** - O(log n) on sorted arrays
- **Jump Search** - O(√n) on sorted arrays
- **Interpolation Search** - O(log log n) on uniformly distributed sorted arrays

### Graph Algorithms

- **Depth-First Search (DFS)** - Graph traversal
- **Breadth-First Search (BFS)** - Graph traversal
- **Dijkstra's Algorithm** - Shortest path
- **Topological Sort** - DAG ordering

## Implementation Guidelines

Each algorithm folder contains:

- **Implementation file** (e.g., `MergeSort.cs`)
- **Test file** (e.g., `MergeSortTests.cs`)
- **README.md** with:
  - How it works
  - Step-by-step walkthrough
  - Time complexity analysis
  - Space complexity analysis
  - Use cases
  - Related LeetCode problems

## Testing

Run tests for all algorithms:

```bash
dotnet test --filter FullyQualifiedName~Algorithms
```

Run tests for a specific algorithm:

```bash
dotnet test --filter MergeSort
```
