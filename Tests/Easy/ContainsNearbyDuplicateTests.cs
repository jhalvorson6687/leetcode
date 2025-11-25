using CSharp_leetcode.Problems.Easy;
using Xunit;

namespace CSharp_leetcode.Tests.Easy;

public class ContainsNearbyDuplicateTests
{
    private readonly ContainsNearbyDuplicate _solution;

    public ContainsNearbyDuplicateTests()
    {
        _solution = new ContainsNearbyDuplicate();
    }

    [Fact]
    public void Test_Example1_ContainsNearbyDuplicate()
    {
        // Arrange
        int[] nums = { 1, 2, 3, 1 };
        int k = 3;

        // Act
        bool result = _solution.Solve(nums, k);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Test_Example2_DoesNotContainNearbyDuplicate()
    {
        // Arrange
        int[] nums = { 1, 0, 1, 1 };
        int k = 1;

        // Act
        bool result = _solution.Solve(nums, k);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Test_Example3_DoesNotContainNearbyDuplicate()
    {
        // Arrange
        int[] nums = { 1, 2, 3, 1, 2, 3 };
        int k = 2;

        // Act
        bool result = _solution.Solve(nums, k);

        // Assert
        Assert.False(result);
    }
}
