using System;

class Program
{
    static void Main()
    {
        int[] arr = { 2, 1, 5, 1, 3, 2 };
        int k = 3;

        int maxSum = MaxSumOfKConsecutive(arr, k);
        Console.WriteLine("Maximum sum of " + k + " consecutive elements: " + maxSum);
    }

    static int MaxSumOfKConsecutive(int[] arr, int k)
    {
        int n = arr.Length;
        if (n < k) return -1;

        int windowSum = 0;
        for (int i = 0; i < k; i++)
            windowSum += arr[i];

        int maxSum = windowSum;

        for (int end = k; end < n; end++)
        {
            windowSum += arr[end] - arr[end - k]; // Add new, remove old
            maxSum = Math.Max(maxSum, windowSum);
        }

        return maxSum;
    }
}
