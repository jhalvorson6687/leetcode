namespace CSharp_leetcode.Problems.Easy;

/// <summary>
/// LeetCode #169 - Majority Element
/// Difficulty: Easy
/// Given an array nums of size n, return the majority element.
/// The majority element is the element that appears more than ⌊n / 2⌋ times.
/// </summary>
public class MajorityElement : ILeetCodeProblem
{
    public int ProblemNumber => 169;
    public string Title => "Majority Element";
    public Difficulty Level => Difficulty.Easy;

    public int Solve(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var item in nums)
        {
            if (!dict.TryAdd(item, 1))
            {
                dict[item] += 1;
            }
        }

        var majorityValue = dict.MaxBy(entry => entry.Value).Key;
        return majorityValue;
    }
}
