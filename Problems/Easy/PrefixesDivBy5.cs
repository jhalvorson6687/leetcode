using System.Numerics;

namespace CSharp_leetcode.Problems.Easy;

/// <summary>
/// LeetCode #1018 - Binary Prefix Divisible By 5
/// Difficulty: Easy
/// You are given a binary array nums (0-indexed).
/// Return an array of booleans answer, where answer[i] is true if the number formed by the binary prefix ending at i is divisible by 5.
/// </summary>
public class PrefixesDivBy5
{
    public IList<bool> Solve(int[] nums)
    {
        List<bool> divBy5 = new List<bool>(nums.Length);
        BigInteger runningTotal = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            runningTotal *= 2;  // runningTotal = runningTotal << 1; can also store remainder only to avoid large number calculations
            if (nums[i] > 0)
            {
                runningTotal += 1;
            }
            divBy5.Add((runningTotal % 5) == 0);
        }

        return divBy5;
    }
}
