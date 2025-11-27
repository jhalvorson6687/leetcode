using CSharp_leetcode.Problems;

namespace CSharp_leetcode.Services;

/// <summary>
/// Service for discovering all LeetCode problem implementations using reflection
/// </summary>
public class ProblemDiscovery
{
    public IEnumerable<ILeetCodeProblem> GetAllProblems()
    {
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
}
