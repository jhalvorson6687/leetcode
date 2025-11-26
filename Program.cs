using System.Text;
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
        // Check if user wants to update README
        if (args.Length > 0 && args[0] == "--update-readme")
        {
            UpdateReadme();
            return;
        }

        Console.WriteLine("\nLeetCode Solutions - C#");
        Console.WriteLine("========================");
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

    static IEnumerable<ILeetCodeProblem> GetAllProblems()
    {
        // Automatically discover all ILeetCodeProblem implementations using reflection
        var assembly = typeof(ILeetCodeProblem).Assembly;
        
        var problemTypes = assembly.GetTypes()
            .Where(t => typeof(ILeetCodeProblem).IsAssignableFrom(t) 
                        && !t.IsInterface 
                        && !t.IsAbstract
                        && t.GetConstructor(Type.EmptyTypes) != null);
        
        return problemTypes
            .Select(t => (ILeetCodeProblem)Activator.CreateInstance(t)!)
            .ToList();
    }

    static void UpdateReadme()
    {
        var readmePath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "README.md");
        readmePath = Path.GetFullPath(readmePath);
        
        if (!File.Exists(readmePath))
        {
            Console.WriteLine($"README.md not found at: {readmePath}");
            return;
        }

        var problems = GetAllProblems();
        var grouped = problems.GroupBy(p => p.Level).OrderBy(g => g.Key);

        var markdown = new StringBuilder();
        markdown.AppendLine("## Current Solutions");
        markdown.AppendLine();

        foreach (var group in grouped)
        {
            markdown.AppendLine($"### {group.Key} ({group.Count()} problems)");
            markdown.AppendLine();
            foreach (var problem in group.OrderBy(p => p.ProblemNumber))
            {
                markdown.AppendLine($"- **#{problem.ProblemNumber}** - {problem.Title}");
            }
            markdown.AppendLine();
        }

        // Read existing README
        var readmeContent = File.ReadAllText(readmePath);
        
        // Find and replace the Current Solutions section
        var startMarker = "## Current Solutions";
        var endMarker = "## Key Features";
        
        var startIndex = readmeContent.IndexOf(startMarker);
        var endIndex = readmeContent.IndexOf(endMarker);
        
        if (startIndex == -1 || endIndex == -1)
        {
            Console.WriteLine("Could not find section markers in README.md");
            return;
        }

        var newContent = readmeContent.Substring(0, startIndex) 
                       + markdown.ToString() 
                       + readmeContent.Substring(endIndex);

        File.WriteAllText(readmePath, newContent);
        Console.WriteLine("[OK] README.md updated successfully!");
        Console.WriteLine($"Total problems: {problems.Count()}");
    }
}


