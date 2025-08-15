using System;

class Program
{
    public static int MaxSumSubarray(int[] nums)
    {
        int maxSum = int.MinValue;
        int currentSum = 0;

        foreach (int val in nums)
        {
            currentSum += val;
            maxSum = Math.Max(currentSum, maxSum);

            if (currentSum < 0)
            {
                currentSum = 0;
            }
        }
        return maxSum;
    }

    public static void Main(string[] args)
    {
        int[] array = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int MaxSum = MaxSumSubarray(array);
        Console.WriteLine($"Maximum Sum of Subarray is: {MaxSum}");
    }
}