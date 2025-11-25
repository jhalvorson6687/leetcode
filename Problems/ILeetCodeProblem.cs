namespace CSharp_leetcode.Problems;

/// <summary>
/// Difficulty levels for LeetCode problems
/// </summary>
public enum Difficulty
{
    Easy,
    Medium,
    Hard
}

/// <summary>
/// Marker interface for all LeetCode problem solutions
/// Provides metadata about the problem without enforcing method signatures
/// </summary>
public interface ILeetCodeProblem
{
    /// <summary>
    /// The LeetCode problem number
    /// </summary>
    int ProblemNumber { get; }

    /// <summary>
    /// The title of the problem
    /// </summary>
    string Title { get; }

    /// <summary>
    /// The difficulty level of the problem
    /// </summary>
    Difficulty Level { get; }
}
