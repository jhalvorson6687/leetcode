using CSharp_leetcode.Problems.Easy;

namespace LeetCode
{
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
            Console.WriteLine("\nExample quick test:\n");

            // Quick example - Two Sum
            var twoSum = new TwoSum();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            var result = twoSum.Solve(nums, target);
            Console.WriteLine($"Two Sum: [{result[0]}, {result[1]}]");

            // Quick example - Is Anagram
            var isAnagram = new IsAnagram();
            bool anagramResult = isAnagram.Solve("anagram", "nagaram");
            Console.WriteLine($"Is Anagram: {anagramResult}");
        }
    }
}

