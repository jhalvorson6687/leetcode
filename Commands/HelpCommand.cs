namespace CSharp_leetcode.Commands;

/// <summary>
/// Default command - displays available commands and testing instructions
/// </summary>
public class HelpCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("\nLeetCode Solutions - C#");
        Console.WriteLine("========================");
        Console.WriteLine("\n--- Commands ---");
        Console.WriteLine("Show help:               dotnet run");
        Console.WriteLine("List problems:           dotnet run -- --list-problems");
        Console.WriteLine("Create new problem:      dotnet run -- --new <ClassName> <Difficulty> <Number> [\"Title\"]");
        Console.WriteLine("Update README:           dotnet run -- --update-readme");
        
        Console.WriteLine("\n--- Testing ---");
        Console.WriteLine("Run all tests:           dotnet test");
        Console.WriteLine("Test specific problem:   dotnet test --filter <ProblemName>");
        Console.WriteLine("Test by difficulty:      dotnet test --filter FullyQualifiedName~Easy/Medium/Hard");
    }
}
