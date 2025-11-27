using CSharp_leetcode.Services;

namespace CSharp_leetcode.Commands;

/// <summary>
/// Command to generate a new problem and test file template
/// </summary>
public class GenerateTemplateCommand : ICommand
{
    private readonly TemplateGenerator _templateGenerator;
    private readonly string _className;
    private readonly string _difficulty;
    private readonly string _problemNumber;
    private readonly string _title;

    public GenerateTemplateCommand(
        TemplateGenerator templateGenerator,
        string className,
        string difficulty,
        string problemNumber,
        string title)
    {
        _templateGenerator = templateGenerator;
        _className = className;
        _difficulty = difficulty;
        _problemNumber = problemNumber;
        _title = title;
    }

    public void Execute()
    {
        _templateGenerator.GenerateTemplate(_className, _difficulty, _problemNumber, _title);
    }
}
