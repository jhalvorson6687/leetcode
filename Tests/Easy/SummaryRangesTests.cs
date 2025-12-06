using CSharp_leetcode.Problems.Easy;
using Xunit;

namespace CSharp_leetcode.Tests.Easy;

public class SummaryRangesTests
{
    private readonly SummaryRanges _solution;

    public SummaryRangesTests()
    {
        _solution = new SummaryRanges();
    }

    [Fact]
    public void Test_Example1()
    {
        // Arrange
        int[] nums = [0,1,2,4,5,7];

        // Act
        var result = _solution.Solve(nums);

        // Assert
        Assert.Equal(["0->2", "4->5", "7"], result);
    }

    [Fact]
    public void Test_Example2()
    {
        // Arrange
        int[] nums = [0,2,3,4,6,8,9];

        // Act
        var result = _solution.Solve(nums);

        // Assert
        Assert.Equal(["0", "2->4", "6", "8->9"], result);
    }

    [Fact]
    public void Test_Example3()
    {
        // Arrange
        int[] nums = [];

        // Act
        var result = _solution.Solve(nums);

        // Assert
        Assert.Equal([], result);
    }

    [Fact]
    public void Test_SingleElement()
    {
        // Arrange
        int[] nums = [5];

        // Act
        var result = _solution.Solve(nums);

        // Assert
        Assert.Equal(["5"], result);
    }

    [Fact]
    public void Test_NoConsecutiveNumbers()
    {
        // Arrange
        int[] nums = [1,3,5,7];

        // Act
        var result = _solution.Solve(nums);

        // Assert
        Assert.Equal(["1", "3", "5", "7"], result);
    }

    [Fact]
    public void Test_AllConsecutiveNumbers()
    {
        // Arrange
        int[] nums = [10,11,12,13,14];

        // Act
        var result = _solution.Solve(nums);

        // Assert
        Assert.Equal(["10->14"], result);
    }
}