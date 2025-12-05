using CSharp_leetcode.Problems.Easy;
using Xunit;

namespace CSharp_leetcode.Tests.Easy;

public class SearchInsertTests
{
    private readonly SearchInsert _solution;

    public SearchInsertTests()
    {
        _solution = new SearchInsert();
    }

    [Fact]
    public void Test_Example1()
    {
        // Arrange
        int[] nums = [1, 3, 5, 6];
        int target = 5;

        // Act
        var result = _solution.Solve(nums, target);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void Test_Example2()
    {
        // Arrange
        int[] nums = [1, 3, 5, 6];
        int target = 2;

        // Act
        var result = _solution.Solve(nums, target);

        // Assert
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void Test_Example3()
    {
        // Arrange
        int[] nums = [1, 3, 5, 6];
        int target = 7;

        // Act
        var result = _solution.Solve(nums, target);

        // Assert
        Assert.Equal(4, result);
    }
}
