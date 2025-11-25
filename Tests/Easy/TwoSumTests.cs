using CSharp_leetcode.Problems.Easy;
using Xunit;

namespace CSharp_leetcode.Tests.Easy;

public class TwoSumTests
{
    private readonly TwoSum _solution;

    public TwoSumTests()
    {
        _solution = new TwoSum();
    }

    [Fact]
    public void Test_Example1()
    {
        // Arrange
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        // Act
        int[] result = _solution.Solve(nums, target);

        // Assert
        Assert.Equal(new int[] { 0, 1 }, result);
    }

    [Fact]
    public void Test_Example2()
    {
        // Arrange
        int[] nums = { 3, 2, 4 };
        int target = 6;

        // Act
        int[] result = _solution.Solve(nums, target);

        // Assert
        Assert.Equal(new int[] { 1, 2 }, result);
    }

    [Fact]
    public void Test_Example3()
    {
        // Arrange
        int[] nums = { 3, 3 };
        int target = 6;

        // Act
        int[] result = _solution.Solve(nums, target);

        // Assert
        Assert.Equal(new int[] { 0, 1 }, result);
    }

    [Fact]
    public void Test_NegativeNumbers()
    {
        // Arrange
        int[] nums = { -1, -2, -3, -4, -5 };
        int target = -8;

        // Act
        int[] result = _solution.Solve(nums, target);

        // Assert
        Assert.Equal(new int[] { 2, 4 }, result);
    }
}
