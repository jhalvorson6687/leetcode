namespace CSharp_leetcode.Problems.Easy;

/// <summary>
/// LeetCode #242 - Valid Anagram
/// Difficulty: Easy
/// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
/// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase.
/// </summary>
public class IsAnagram
{
    public bool Solve(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var map = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (map.TryGetValue(c, out int value))
            {
                map[c] = value + 1;
            }
            else
            {
                map.Add(c, 1);
            }
        }

        foreach (var c in t)
        {
            if (map.TryGetValue(c, out int value))
            {
                map[c] = value - 1;
                if (map[c] < 0) return false;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}
