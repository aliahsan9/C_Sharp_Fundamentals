using System;

class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
                return new int[] { map[complement], i };

            map[nums[i]] = i;
        }

        return new int[] { -1, -1 };

    }
}
class Program
{
    static void Main(String[] args)
    {
        int[] arr = { 2, 7, 5, 6, 8 };

        int[] result = Solution.TwoSum(arr, 9);

        Console.WriteLine($"Result Indices are: {result[0]}, {result[1]}");
    }
}