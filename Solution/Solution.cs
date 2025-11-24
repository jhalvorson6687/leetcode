using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
            // Console.WriteLine(sell + " " + buy);
            max = prices[sell] - prices[buy];
            return max > 0 ? max : 0;
        }

        /* Can be more efficient by using modulo properties to avoid large number calculations. Also bit shift left 1 to multiply by 2. */
        public IList<bool> PrefixesDivBy5(int[] nums) {
            List<bool> divBy5 = new List<bool>(nums.Length);
            BigInteger runningTotal = 0;
            for (var i = 0; i < nums.Length; i++) {
                runningTotal *= 2;  // runningTotal = runningTotal << 1; can also store remainder only to avoid large number calculations
                if (nums[i] > 0)
                {
                    runningTotal += 1;
                }
                divBy5.Add((runningTotal % 5) == 0);
            }

            return divBy5;
        }
    }
}