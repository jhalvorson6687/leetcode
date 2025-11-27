using CSharp_leetcode.Problems.Medium;
using Xunit;

namespace CSharp_leetcode.Tests.Medium;

public class GroupAnagramTests
{
    private readonly GroupAnagram _solution;

    public GroupAnagramTests()
    {
        _solution = new GroupAnagram();
    }

    [Fact]
    public void Test_Example1_ValidAnagram()
    {
        // Arrange
        string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

        // Act
        IList<IList<string>> result = _solution.Solve(strs);

        // Assert
        var expected = new List<IList<string>>
        {
            new List<string> { "eat", "tea", "ate" },
            new List<string> { "tan", "nat" },
            new List<string> { "bat" }
        };
        Assert.Equal(expected.Count, result.Count);
    }

    [Fact]
    public void Test_EmptyStrings()
    {
        // Arrange
        string[] strs = {""};

        // Act
        IList<IList<string>> result = _solution.Solve(strs);

        // Assert
        var expected = new List<IList<string>>
        {
            new List<string> {""}
        };
        Assert.Equal(expected.Count, result.Count);
    }

    [Fact]
    public void Test_SingleCharacterStrings()
    {
        // Arrange
        string[] strs = { "a", "b", "a" };

        // Act
        IList<IList<string>> result = _solution.Solve(strs);

        // Assert
        var expected = new List<IList<string>>
        {
            new List<string> { "a", "a" },
            new List<string> { "b" }
        };
        Assert.Equal(expected.Count, result.Count);
    }

    [Fact]
    public void Test_NoAnagrams()
    {
        // Arrange
        string[] strs = { "abc", "def", "ghi" };

        // Act
        IList<IList<string>> result = _solution.Solve(strs);

        // Assert
        var expected = new List<IList<string>>
        {
            new List<string> { "abc" },
            new List<string> { "def" },
            new List<string> { "ghi" }
        };
        Assert.Equal(expected.Count, result.Count);
    }

    [Fact]
    public void Test_SingleCharacter()
    {
        // Arrange
        string[] strs = {"a"};

        // Act
        IList<IList<string>> result = _solution.Solve(strs);

        // Assert
        var expected = new List<IList<string>>
        {
            new List<string> {"a"}
        };
        Assert.Equal(expected.Count, result.Count);
    }
}
