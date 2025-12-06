using CSharp_leetcode.Problems.Easy;
using Xunit;

namespace CSharp_leetcode.Tests.Easy;

public class FindContentChildrenTests
{
    private readonly FindContentChildren _solution;

    public FindContentChildrenTests()
    {
        _solution = new FindContentChildren();
    }

    [Fact]
    public void Test_Example1()
    {
        // Arrange
        int[] g = [1, 2, 3];
        int[] s = [1, 1];

        // Act
        var result = _solution.Solve(g, s);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void Test_Example2()
    {
        // Arrange
        int[] g = [1, 2];
        int[] s = [1, 2, 3];

        // Act
        var result = _solution.Solve(g, s);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void Test_NoCookies()
    {
        // Arrange
        int[] g = [1, 2, 3];
        int[] s = [];

        // Act
        var result = _solution.Solve(g, s);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Test_NoChildren()
    {
        // Arrange
        int[] g = [];
        int[] s = [1, 2, 3];

        // Act
        var result = _solution.Solve(g, s);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Test_EqualGreedAndSizes()
    {
        // Arrange
        int[] g = [1, 2, 3];
        int[] s = [1, 2, 3];

        // Act
        var result = _solution.Solve(g, s);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void Test_LargeInput()
    {
        // Arrange
        int n = 10000;
        int[] g = [.. Enumerable.Range(1, n)];
        int[] s = [.. Enumerable.Range(1, n)];

        // Act
        var result = _solution.Solve(g, s);

        // Assert
        Assert.Equal(n, result);
    }
}
