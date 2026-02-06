using System;
using System.Collections.Generic;

public class Solution
{
    public int SumOfUnique(int[] nums)
    {
        // Dictionary to store frequency of each number
        Dictionary<int, int> count = new Dictionary<int, int>();

        // Count frequencies
        foreach (int num in nums)
        {
            if (count.ContainsKey(num))
                count[num]++;
            else
                count[num] = 1;
        }

        // Sum numbers that appear exactly once
        int result = 0;
        foreach (var kvp in count)
        {
            if (kvp.Value == 1)
                result += kvp.Key;
        }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 2 };
        Solution sol = new Solution();
        int result = sol.SumOfUnique(nums);
        Console.WriteLine($"Sum of unique elements: {result}");
    }
}
