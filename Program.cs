using CSharp_leetcode.Solution;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments provided. Please provide the solution name as an argument.");
                return;
            }

            Solution solution = new Solution();

            switch (args[0])
            {
                case "MajorityElement":
                    int[] nums = {1,2,3,1,2,3,1,2,3,1,2,3,1};
                    Console.WriteLine(solution.MajorityElement(nums));
                    break;

                case "MaxProfit":
                    int[] prices = { 7, 1, 5, 3, 6, 4 };
                    Console.WriteLine(solution.MaxProfit(prices));
                    break;

                case "PrefixesDivBy5":
                    int[] binaryNums = { 0,1,1 };
                    var result = solution.PrefixesDivBy5(binaryNums);
                    Console.WriteLine(string.Join(", ", result));
                    break;

                case "WordPattern":
                    string pattern = "abba";
                    string s = "dog cat cat dog";
                    Console.WriteLine(solution.WordPattern(pattern, s));
                    break;

                case "IsAnagram":
                    string s1 = "anagram";
                    string s2 = "nagaram";
                    Console.WriteLine(solution.IsAnagram(s1, s2));
                    break;

                case "TwoSum":
                    int[] numbers = { 2,7,11,15 };
                    int target = 9;
                    var indices = solution.TwoSum(numbers, target);
                    Console.WriteLine($"[{indices[0]}, {indices[1]}]");
                    break;

                case "IsHappy":
                    int n = 19;
                    Console.WriteLine(solution.IsHappy(n));
                    break;

                default:
                    Console.WriteLine("Solution not found for the given argument.");
                    break;
            }
        }
    }
}

