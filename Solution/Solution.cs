using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_leetcode.Solution
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            foreach(var item in nums)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item] += 1;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

            var majorityValue = dict.MaxBy(entry => entry.Value).Key;
            return majorityValue;
        }

        public int MaxProfit(int[] prices)
        {
            int buy = 0; //index for best buy
            int sell = prices.Length - 1; //index for best sell
            int i = 0;
            int j = (prices.Length/2) + 1;
            int max = 0;

            while(i < prices.Length/2)
            {
                if (prices[j] >= prices[sell])
                {
                    sell = j;
                }
                if (prices[i] <= prices[buy])
                {
                    buy = i;
                }
                j--;
                i++;
            }
            Console.WriteLine(sell + " " + buy);
            max = prices[sell] - prices[buy];
            return max > 0 ? max : 0;
        }
    }
}