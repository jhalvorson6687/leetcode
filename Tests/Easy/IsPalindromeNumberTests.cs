using CSharp_leetcode.Problems.Easy;
using Xunit;

namespace CSharp_leetcode.Tests.Easy;

public class IsPalindromeNumberTests
{
    private readonly IsPalindromeNumber _solution;

    public IsPalindromeNumberTests()
    {
        _solution = new IsPalindromeNumber();
    }

    [Fact]
    public void Test_Example1()
    {
        // Arrange
        int x = 121;

        // Act
        var result = _solution.Solve(x);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Test_Example2()
    {
        // Arrange
        int x = -121;

        // Act
        var result = _solution.Solve(x);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Test_Example3()
    {
        // Arrange
        int x = 10;

        // Act
        var result = _solution.Solve(x);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Test_Example1_Solve2()
    {
        // Arrange
        int x = 121;

        // Act
        var result = _solution.Solve2(x);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Test_Example2_Solve2()
    {
        // Arrange
        int x = -121;

        // Act
        var result = _solution.Solve2(x);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Test_Example3_Solve2()
    {
        // Arrange
        int x = 10;

        // Act
        var result = _solution.Solve2(x);

        // Assert
        Assert.False(result);
    }
}
