using CSharp_leetcode.Problems.Easy;
using Xunit;

namespace CSharp_leetcode.Tests.Easy;

public class MajorityElementTests
{
    private readonly MajorityElement _solution;

    public MajorityElementTests()
    {
        _solution = new MajorityElement();
    }

    [Fact]
    public void Test_Example1()
    {
        // Arrange
        int[] nums = { 3, 2, 3 };

        // Act
        int result = _solution.Solve(nums);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void Test_Example2()
    {
        // Arrange
        int[] nums = { 2, 2, 1, 1, 1, 2, 2 };

        // Act
        int result = _solution.Solve(nums);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void Test_RepeatingPattern()
    {
        // Arrange
        int[] nums = { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1 };

        // Act
        int result = _solution.Solve(nums);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void Test_SingleElement()
    {
        // Arrange
        int[] nums = { 1 };

        // Act
        int result = _solution.Solve(nums);

        // Assert
        Assert.Equal(1, result);
    }
}
