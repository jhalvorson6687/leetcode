using CSharp_leetcode.Problems.Easy;
using Xunit;

namespace CSharp_leetcode.Tests.Easy;

public class WordPatternTests
{
    private readonly WordPattern _solution;

    public WordPatternTests()
    {
        _solution = new WordPattern();
    }

    [Fact]
    public void Test_Example1_MatchesPattern()
    {
        // Arrange
        string pattern = "abba";
        string s = "dog cat cat dog";

        // Act
        bool result = _solution.Solve(pattern, s);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Test_Example2_DoesNotMatch()
    {
        // Arrange
        string pattern = "abba";
        string s = "dog cat cat fish";

        // Act
        bool result = _solution.Solve(pattern, s);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Test_Example3_DoesNotMatch()
    {
        // Arrange
        string pattern = "aaaa";
        string s = "dog cat cat dog";

        // Act
        bool result = _solution.Solve(pattern, s);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Test_DifferentLengths()
    {
        // Arrange
        string pattern = "abc";
        string s = "dog cat";

        // Act
        bool result = _solution.Solve(pattern, s);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Test_SingleCharPattern()
    {
        // Arrange
        string pattern = "a";
        string s = "dog";

        // Act
        bool result = _solution.Solve(pattern, s);

        // Assert
        Assert.True(result);
    }
}
