namespace CSharp_leetcode.Problems.Easy;

/// <summary>
/// LeetCode #290 - Word Pattern
/// Difficulty: Easy
/// Given a pattern and a string s, find if s follows the same pattern.
/// Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.
/// </summary>
public class WordPattern : ILeetCodeProblem
{
    public int ProblemNumber => 290;
    public string Title => "Word Pattern";
    public Difficulty Level => Difficulty.Easy;

    public bool Solve(string pattern, string s)
    {
        var map1 = new Dictionary<char, string>();
        var map2 = new Dictionary<string, char>();
        string[] words = s.Split(' ');
        if (pattern.Length != words.Length) return false;

        for (var i = 0; i < words.Length; i++)
        {
            if (map1.ContainsKey(pattern[i]))
            {
                if (map1[pattern[i]] != words[i]) return false;
            }
            else if (map2.ContainsKey(words[i]))
            {
                if (map2[words[i]] != pattern[i]) return false;
            }
            else
            {
                map1.Add(pattern[i], words[i]);
                map2.Add(words[i], pattern[i]);
            }
        }

        return true;
    }
}
