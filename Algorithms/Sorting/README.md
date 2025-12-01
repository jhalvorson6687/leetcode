# Merge Sort

Merge Sort is a divide-and-conquer algorithm that divides the array into two halves, recursively sorts them, and then merges the sorted halves.

## How It Works

1. **Divide**: Split the array into two halves
2. **Conquer**: Recursively sort each half
3. **Combine**: Merge the two sorted halves

## Time Complexity

- **Best Case**: O(n log n)
- **Average Case**: O(n log n)
- **Worst Case**: O(n log n)

Always O(n log n) regardless of input!

## Space Complexity

O(n) - requires additional space for merging

## Advantages

- Stable sort (maintains relative order of equal elements)
- Predictable O(n log n) performance
- Works well for linked lists

## Disadvantages

- Requires O(n) extra space
- Not in-place
- Slower than Quick Sort in practice for arrays

## Use Cases

- Sorting linked lists
- External sorting (data doesn't fit in memory)
- When stable sort is required
- When predictable performance is needed

## Related LeetCode Problems

- #148 - Sort List
- #88 - Merge Sorted Array
- #21 - Merge Two Sorted Lists
