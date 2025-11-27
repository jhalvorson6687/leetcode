using CSharp_leetcode.Problems;

namespace CSharp_leetcode.Services;

/// <summary>
/// Service for generating problem and test file templates
/// </summary>
public class TemplateGenerator
{
    public void GenerateTemplate(string className, string difficultyStr, string problemNumber, string title)
    {
        // Validate difficulty
        if (!Enum.TryParse<Difficulty>(difficultyStr, true, out var difficulty))
        {
            Console.WriteLine($"Invalid difficulty: {difficultyStr}. Use Easy, Medium, or Hard.");
            return;
        }

        // Get project root (go up from bin/Debug/net7.0)
        var projectRoot = Path.Combine(AppContext.BaseDirectory, "..", "..", "..");
        projectRoot = Path.GetFullPath(projectRoot);

        // Create directory paths
        var problemDir = Path.Combine(projectRoot, "Problems", difficultyStr);
        var testDir = Path.Combine(projectRoot, "Tests", difficultyStr);

        Directory.CreateDirectory(problemDir);
        Directory.CreateDirectory(testDir);

        // Generate problem file
        var problemFile = Path.Combine(problemDir, $"{className}.cs");
        var problemContent = GenerateProblemClass(className, difficultyStr, problemNumber, title, difficulty);
        
        if (File.Exists(problemFile))
        {
            Console.WriteLine($"Error: {problemFile} already exists!");
            return;
        }

        File.WriteAllText(problemFile, problemContent);
        Console.WriteLine($"[OK] Created: Problems/{difficultyStr}/{className}.cs");

        // Generate test file
        var testFile = Path.Combine(testDir, $"{className}Tests.cs");
        var testContent = GenerateTestClass(className, difficultyStr);

        if (File.Exists(testFile))
        {
            Console.WriteLine($"Warning: {testFile} already exists! Skipping test file.");
        }
        else
        {
            File.WriteAllText(testFile, testContent);
            Console.WriteLine($"[OK] Created: Tests/{difficultyStr}/{className}Tests.cs");
        }

        Console.WriteLine("\nNext steps:");
        Console.WriteLine($"1. Implement the Solve method in {className}.cs");
        Console.WriteLine($"2. Add test cases in {className}Tests.cs");
        Console.WriteLine("3. Run: dotnet test");
        Console.WriteLine("4. Update README: dotnet run -- --update-readme");
    }

    private string GenerateProblemClass(string className, string difficulty, string problemNumber, string title, Difficulty difficultyEnum)
    {
        return $@"namespace CSharp_leetcode.Problems.{difficulty};

/// <summary>
/// LeetCode #{problemNumber} - {title}
/// Difficulty: {difficulty}
/// TODO: Add problem description here
/// </summary>
public class {className} : ILeetCodeProblem
{{
    public int ProblemNumber => {problemNumber};
    public string Title => ""{title}"";
    public Difficulty Level => Difficulty.{difficultyEnum};

    public object Solve()
    {{
        // TODO: Implement solution
        throw new NotImplementedException();
    }}
}}
";
    }

    private string GenerateTestClass(string className, string difficulty)
    {
        return $@"using CSharp_leetcode.Problems.{difficulty};
using Xunit;

namespace CSharp_leetcode.Tests.{difficulty};

public class {className}Tests
{{
    private readonly {className} _solution;

    public {className}Tests()
    {{
        _solution = new {className}();
    }}

    [Fact]
    public void Test_Example1()
    {{
        // Arrange
        // TODO: Add test input

        // Act
        var result = _solution.Solve();

        // Assert
        // TODO: Add assertions
        Assert.True(false, ""Test not implemented"");
    }}

    [Fact]
    public void Test_Example2()
    {{
        // Arrange
        // TODO: Add test input

        // Act
        var result = _solution.Solve();

        // Assert
        // TODO: Add assertions
        Assert.True(false, ""Test not implemented"");
    }}
}}
";
    }
}
