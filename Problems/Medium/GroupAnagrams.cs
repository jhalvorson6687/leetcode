namespace CSharp_leetcode.Problems.Medium;

/// <summary>
/// LeetCode #49 - Group Anagrams
/// Difficulty: Medium
/// Given an array of strings strs, group the anagrams together. You can return the answer in any order.
/// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
/// </summary>
public class GroupAnagram : ILeetCodeProblem
{
    public int ProblemNumber => 49;
    public string Title => "Group Anagrams";
    public Difficulty Level => Difficulty.Medium;

    public IList<IList<string>> Solve(string[] strs)
    {
        //["eat","tea","tan","ate","nat","bat"]
        var map = new Dictionary<string, List<string>>();
        foreach (var str in strs)
        {
            var charArray = str.ToCharArray();
            Array.Sort(charArray);
            var key = new string(charArray);
            if (map.TryGetValue(key, out var list))
            {
                list.Add(str);
            }
            else
            {
                map.Add(key, [str]);
            }
        }

        return [.. map.Values];
    }
}
