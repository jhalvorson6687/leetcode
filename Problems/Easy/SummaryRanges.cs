namespace CSharp_leetcode.Problems.Easy;

/// <summary>
/// LeetCode #228 - Summary Ranges
/// Difficulty: Easy
/// You are given a sorted unique integer array nums. A range [a,b] is the set of all integers from a to b (inclusive).
/// Return the smallest sorted list of ranges that cover all the numbers in the array exactly.
/// That is, each element of nums is covered by exactly one of the ranges, and there is no integer
/// x such that x is in one of the ranges but not in nums.
/// Each range [a,b] in the list should be output as: "a->b" if a != b, and "a" if a == b.
/// </summary>
public class SummaryRanges : ILeetCodeProblem
{
    public int ProblemNumber => 228;
    public string Title => "Summary Ranges";
    public Difficulty Level => Difficulty.Easy;

    public IList<string> Solve(int[] nums)
    {
        var result = new List<string>();
        if (nums.Length == 0) return result;
        int startRange = nums[0];
        int endRange = startRange;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i-1] + 1)
            {
                if (startRange == endRange)
                {
                    result.Add($"{startRange}");
                }
                else
                {
                    result.Add($"{startRange}->{endRange}");
                }
                startRange = endRange = nums[i];
            }
            else
            {
                endRange = nums[i];
            }
        }
        if (startRange == endRange)
        {
            result.Add($"{startRange}");
        }
        else
        {
            result.Add($"{startRange}->{endRange}");
        }
        return result;
    }
}
