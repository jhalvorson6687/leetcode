using System.Text;
using CSharp_leetcode.Services;

namespace CSharp_leetcode.Commands;

/// <summary>
/// Command to update the Current Solutions section in README.md
/// </summary>
public class UpdateReadmeCommand : ICommand
{
    private readonly ProblemDiscovery _problemDiscovery;

    public UpdateReadmeCommand(ProblemDiscovery problemDiscovery)
    {
        _problemDiscovery = problemDiscovery;
    }

    public void Execute()
    {
        var readmePath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "README.md");
        readmePath = Path.GetFullPath(readmePath);
        
        if (!File.Exists(readmePath))
        {
            Console.WriteLine($"README.md not found at: {readmePath}");
            return;
        }

        var problems = _problemDiscovery.GetAllProblems();
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
