namespace CSharp_leetcode.Problems.Easy;

/// <summary>
/// LeetCode #455 - Assign Cookies
/// Difficulty: Easy
/// Assume you are an awesome parent and want to give your children some cookies.
/// But, you should give each child at most one cookie. Each child i has a greed factor g[i],
/// which is the minimum size of a cookie that the child will be content with; and each
/// cookie j has a size s[j]. If s[j] >= g[i], we can assign the cookie j to the child i, and
/// the child i will be content. Your goal is to maximize the number of your content children and output the maximum number.
/// </summary>
public class FindContentChildren : ILeetCodeProblem
{
    public int ProblemNumber => 455;
    public string Title => "Assign Cookies";
    public Difficulty Level => Difficulty.Easy;

    public int Solve(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);
        int i = 0;
        int j = 0;
        while (i < g.Length && j < s.Length)
        {
            if (s[j] >= g[i])
            {
                i++;
            }
            j++;
        }

        return i;
    }
}
