using System.Numerics;

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

        public IList<bool> PrefixesDivBy5(int[] nums)
        {
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

        public bool WordPattern(string pattern, string s)
        {
            var map1 = new Dictionary<char, string>();
            var map2 = new Dictionary<string, char>();
            string[] words = s.Split(' ');
            if (pattern.Length != words.Length) return false;

            for (var i = 0; i < words.Length; i++)
            {
                if (map1.ContainsKey(pattern[i]))
                {
                    if (map1[pattern[i]] != words[i]) return false;
                }
                else if (map2.ContainsKey(words[i]))
                {
                    if (map2[words[i]] != pattern[i]) return false;
                }
                else {
                    map1.Add(pattern[i], words[i]);
                    map2.Add(words[i], pattern[i]);
                }
            }

            return true;
        }
    
        public bool IsAnagram(string s, string t) {
            if (s.Length != t.Length) return false;
            
            var map = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (map.TryGetValue(c, out int value))
                {
                    map[c] = value + 1;
                }
                else 
                {
                    map.Add(c, 1);
                }
            }

            foreach (var c in t)
            {
                if (map.TryGetValue(c, out int value))
                {
                    map[c] = value - 1;
                    if (map[c] < 0) return false;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}