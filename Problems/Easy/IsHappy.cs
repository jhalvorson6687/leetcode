namespace CSharp_leetcode.Problems.Easy;

/// <summary>
/// LeetCode #202 - Happy Number
/// Difficulty: Easy
/// A happy number is a number defined by the following process:
/// Starting with any positive integer, replace the number by the sum of the squares of its digits.
/// Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
/// Those numbers for which this process ends in 1 are happy.
/// </summary>
public class IsHappy
{
    public bool Solve(int n)
    {
        var seen = new HashSet<int>();
        while (n != 1)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }
            if (seen.Contains(sum))
            {
                return false;
            }
            seen.Add(sum);
            n = sum;
        }
        return true;
    }
}
