using System;

class TwoSum
{
    static int[] TwoSumMethod(int[] nums, int target)
    {
        // Brute force approach  
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int sum = nums[i] + nums[j];

                if (sum == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        return new int[] { -1, -1 };
    }

    static void Main(string[] args)
    {
        int[] arr = { 2, 7, 8, 9, 10 };

        int[] result = TwoSumMethod(arr, 109);

        Console.WriteLine($"Indices are: {result[0]}, {result[1]}");
    }
}
