using CSharp_leetcode.Problems.Easy;
using CSharp_leetcode.Services;

namespace CSharp_leetcode.Commands;

/// <summary>
/// Lists all available LeetCode problems with example solutions
/// </summary>
public class ListProblemsCommand : ICommand
{
    private readonly ProblemDiscovery _problemDiscovery;

    public ListProblemsCommand(ProblemDiscovery problemDiscovery)
    {
        _problemDiscovery = problemDiscovery;
    }

    public void Execute()
    {
        Console.WriteLine("\n--- Available Problems ---");
        var problems = _problemDiscovery.GetAllProblems();
        foreach (var problem in problems.OrderBy(p => p.ProblemNumber))
        {
            Console.WriteLine($"#{problem.ProblemNumber} - {problem.Title} ({problem.Level})");
        }

        Console.WriteLine("\n--- Example Solutions ---");

        // Quick example - Two Sum
        var twoSum = new TwoSum();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        var result = twoSum.Solve(nums, target);
        Console.WriteLine($"{twoSum.Title}: [{result[0]}, {result[1]}]");

        // Quick example - Is Anagram
        var isAnagram = new IsAnagram();
        bool anagramResult = isAnagram.Solve("anagram", "nagaram");
        Console.WriteLine($"{isAnagram.Title}: {anagramResult}");
    }
}
