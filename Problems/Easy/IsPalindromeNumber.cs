namespace CSharp_leetcode.Problems.Easy;

/// <summary>
/// LeetCode #9 - Palindrome Number
/// Difficulty: Easy
/// Given an integer x, return true if x is a palindrome, and false otherwise.
/// </summary>
public class IsPalindromeNumber : ILeetCodeProblem
{
    public int ProblemNumber => 9;
    public string Title => "Palindrome Number";
    public Difficulty Level => Difficulty.Easy;

    public bool Solve(int x)
    {
        var str = x.ToString();
        var left = 0;
        var right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right]) return false;
            left++;
            right--;
        }
        return true;
    }

    // Follow up question: solve without converting to string
    public bool Solve2(int x)
    {
        var reverse = 0;
        var temp = x;
        while (x > 0)
        {
            reverse = (reverse * 10) + (x % 10);
            x /= 10;
        }

        return reverse == temp;
    }
}
