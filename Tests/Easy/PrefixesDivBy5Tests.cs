using CSharp_leetcode.Problems.Easy;
using Xunit;

namespace CSharp_leetcode.Tests.Easy;

public class PrefixesDivBy5Tests
{
    private readonly PrefixesDivBy5 _solution;

    public PrefixesDivBy5Tests()
    {
        _solution = new PrefixesDivBy5();
    }

    [Fact]
    public void Test_Example1()
    {
        // Arrange
        int[] nums = { 0, 1, 1 };

        // Act
        IList<bool> result = _solution.Solve(nums);

        // Assert
        Assert.Equal(new List<bool> { true, false, false }, result);
    }

    [Fact]
    public void Test_Example2()
    {
        // Arrange
        int[] nums = { 1, 1, 1 };

        // Act
        IList<bool> result = _solution.Solve(nums);

        // Assert
        Assert.Equal(new List<bool> { false, false, false }, result);
    }

    [Fact]
    public void Test_SingleZero()
    {
        // Arrange
        int[] nums = { 0 };

        // Act
        IList<bool> result = _solution.Solve(nums);

        // Assert
        Assert.Equal(new List<bool> { true }, result);
    }

    [Fact]
    public void Test_LongerSequence()
    {
        // Arrange
        int[] nums = { 1, 0, 1, 0, 1 };

        // Act
        IList<bool> result = _solution.Solve(nums);

        // Assert
        // Binary: 1 -> 10 -> 101 -> 1010 -> 10101
        // Decimal: 1, 2, 5, 10, 21
        Assert.Equal(new List<bool> { false, false, true, true, false }, result);
    }
}
