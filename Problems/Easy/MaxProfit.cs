namespace CSharp_leetcode.Problems.Easy;

/// <summary>
/// LeetCode #121 - Best Time to Buy and Sell Stock
/// Difficulty: Easy
/// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
/// Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
/// </summary>
public class MaxProfit : ILeetCodeProblem
{
    public int ProblemNumber => 121;
    public string Title => "Best Time to Buy and Sell Stock";
    public Difficulty Level => Difficulty.Easy;

    public int Solve(int[] prices)
    {
        if (prices.Length < 2) return 0;

        int minPrice = prices[0];
        int maxProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            // Update max profit if we sell at current price
            maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
            
            // Update minimum price seen so far
            minPrice = Math.Min(minPrice, prices[i]);
        }

        return maxProfit;
    }
}
