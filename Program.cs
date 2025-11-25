using CSharp_leetcode.Problems;
using CSharp_leetcode.Problems.Easy;

namespace LeetCode;

/// <summary>
/// Main entry point - Use this to quickly test individual solutions
/// For comprehensive testing, run: dotnet test
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("LeetCode Solutions - C#");
        Console.WriteLine("========================\n");
        Console.WriteLine("To run all tests, use: dotnet test");
        Console.WriteLine("To run tests for a specific problem, use: dotnet test --filter <ProblemName>");
        Console.WriteLine("To run tests for a specific difficulty, use: dotnet test --filter FullyQualifiedName~Easy/Medium/Hard");
        
        // Demonstrate the interface - list all problems
        Console.WriteLine("\n--- Available Problems ---");
        var problems = GetAllProblems();
        foreach (var problem in problems.OrderBy(p => p.ProblemNumber))
        {
            Console.WriteLine($"#{problem.ProblemNumber} - {problem.Title} ({problem.Level})");
        }

        Console.WriteLine("\n--- Example Solutions ---\n");

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

    static IEnumerable<ILeetCodeProblem> GetAllProblems()
    {
        // This could be automated with reflection, but keeping it simple for now
        return new ILeetCodeProblem[]
        {
            new TwoSum(),
            new MaxProfit(),
            new MajorityElement(),
            new IsHappy(),
            new IsAnagram(),
            new WordPattern(),
            new PrefixesDivBy5()
        };
    }
}


