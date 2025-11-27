using CSharp_leetcode.Commands;
using CSharp_leetcode.Services;

namespace LeetCode;

/// <summary>
/// Main entry point - Routes commands to appropriate handlers
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        // Create services
        var problemDiscovery = new ProblemDiscovery();
        var templateGenerator = new TemplateGenerator();

        // Route to appropriate command
        ICommand command;

        if (args.Length > 0 && args[0] == "--update-readme")
        {
            command = new UpdateReadmeCommand(problemDiscovery);
        }
        else if (args.Length > 0 && args[0] == "--list-problems")
        {
            command = new ListProblemsCommand(problemDiscovery);
        }
        else if (args.Length > 0 && args[0] == "--new")
        {
            if (args.Length < 4)
            {
                Console.WriteLine("Usage: dotnet run -- --new <ClassName> <Difficulty> <ProblemNumber> [\"Problem Title\"]");
                Console.WriteLine("Example: dotnet run -- --new TwoPointers Medium 167 \"Two Sum II\"");
                return;
            }
            
            string className = args[1];
            string difficulty = args[2];
            string problemNumber = args[3];
            string title = args.Length > 4 ? args[4] : className;
            
            command = new GenerateTemplateCommand(templateGenerator, className, difficulty, problemNumber, title);
        }
        else
        {
            // Default: show help
            command = new HelpCommand();
        }

        command.Execute();
    }
}
