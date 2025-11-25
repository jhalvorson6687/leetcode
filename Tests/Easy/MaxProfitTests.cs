using CSharp_leetcode.Problems.Easy;
using Xunit;

namespace CSharp_leetcode.Tests.Easy;

public class MaxProfitTests
{
    private readonly MaxProfit _solution;

    public MaxProfitTests()
    {
        _solution = new MaxProfit();
    }

    [Fact]
    public void Test_Example1()
    {
        // Arrange
        int[] prices = { 7, 1, 5, 3, 6, 4 };

        // Act
        int result = _solution.Solve(prices);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Test_Example2_NoProfit()
    {
        // Arrange
        int[] prices = { 7, 6, 4, 3, 1 };

        // Act
        int result = _solution.Solve(prices);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Test_TwoElements()
    {
        // Arrange
        int[] prices = { 1, 2 };

        // Act
        int result = _solution.Solve(prices);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void Test_ConstantPrices()
    {
        // Arrange
        int[] prices = { 5, 5, 5, 5 };

        // Act
        int result = _solution.Solve(prices);

        // Assert
        Assert.Equal(0, result);
    }
}
