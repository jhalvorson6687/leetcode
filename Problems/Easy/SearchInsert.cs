namespace CSharp_leetcode.Problems.Easy;

/// <summary>
/// LeetCode #35 - Search Insert Position
/// Difficulty: Easy
/// Given a sorted array of distinct integers and a target value, 
/// return the index if the target is found. If not, return the index where it would be if it were inserted in order.
/// </summary>
public class SearchInsert : ILeetCodeProblem
{
    public int ProblemNumber => 35;
    public string Title => "Search Insert Position";
    public Difficulty Level => Difficulty.Easy;

    public int Solve(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length;
        
        while (left < right)
        {
            int mid = (right + left) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        return left;
    }
}
