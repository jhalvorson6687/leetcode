using CSharp_leetcode.Problems.Easy;
using Xunit;

namespace CSharp_leetcode.Tests.Easy;

public class IsAnagramTests
{
    private readonly IsAnagram _solution;

    public IsAnagramTests()
    {
        _solution = new IsAnagram();
    }

    [Fact]
    public void Test_Example1_ValidAnagram()
    {
        // Arrange
        string s = "anagram";
        string t = "nagaram";

        // Act
        bool result = _solution.Solve(s, t);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Test_Example2_NotAnagram()
    {
        // Arrange
        string s = "rat";
        string t = "car";

        // Act
        bool result = _solution.Solve(s, t);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Test_DifferentLengths()
    {
        // Arrange
        string s = "hello";
        string t = "helloworld";

        // Act
        bool result = _solution.Solve(s, t);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Test_EmptyStrings()
    {
        // Arrange
        string s = "";
        string t = "";

        // Act
        bool result = _solution.Solve(s, t);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Test_SingleCharacter()
    {
        // Arrange
        string s = "a";
        string t = "a";

        // Act
        bool result = _solution.Solve(s, t);

        // Assert
        Assert.True(result);
    }
}
