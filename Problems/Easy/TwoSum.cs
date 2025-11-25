namespace CSharp_leetcode.Problems.Easy;

/// <summary>
/// LeetCode #1 - Two Sum
/// Difficulty: Easy
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// </summary>
public class TwoSum : ILeetCodeProblem
{
    public int ProblemNumber => 1;
    public string Title => "Two Sum";
    public Difficulty Level => Difficulty.Easy;

    public int[] Solve(int[] nums, int target)
    {
        var d = new Dictionary<int, int>();
        int diff;
        for (var i = 0; i < nums.Length; i++)
        {
            diff = target - nums[i];
            if (d.TryGetValue(nums[i], out var value))
            {
                return new int[] { d[nums[i]], i };
            }
            d[diff] = i;
        }
        return Array.Empty<int>();
    }
}
