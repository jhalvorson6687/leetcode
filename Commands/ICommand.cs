namespace CSharp_leetcode.Commands;

/// <summary>
/// Interface for command pattern - each command handles a specific CLI action
/// </summary>
public interface ICommand
{
    void Execute();
}
