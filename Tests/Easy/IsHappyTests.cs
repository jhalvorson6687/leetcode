using CSharp_leetcode.Problems.Easy;
using Xunit;

namespace CSharp_leetcode.Tests.Easy;

public class IsHappyTests
{
    private readonly IsHappy _solution;

    public IsHappyTests()
    {
        _solution = new IsHappy();
    }

    [Fact]
    public void Test_Example1_HappyNumber()
    {
        // Arrange
        int n = 19;

        // Act
        bool result = _solution.Solve(n);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Test_Example2_NotHappy()
    {
        // Arrange
        int n = 2;

        // Act
        bool result = _solution.Solve(n);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Test_Number1_IsHappy()
    {
        // Arrange
        int n = 1;

        // Act
        bool result = _solution.Solve(n);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Test_Number7_IsHappy()
    {
        // Arrange
        int n = 7;

        // Act
        bool result = _solution.Solve(n);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Test_Number100_IsHappy()
    {
        // Arrange
        int n = 100;

        // Act
        bool result = _solution.Solve(n);

        // Assert
        Assert.True(result);
    }
}
