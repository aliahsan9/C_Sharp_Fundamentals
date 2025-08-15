using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
        int n = arr.Length;

        int[] dp = new int[n];  // stores length of LIS ending at index i
        int[] prev = new int[n]; // stores previous index in LIS
        int maxLength = 0;
        int lastIndex = 0;

        for (int i = 0; i < n; i++)
        {
            dp[i] = 1; // every element can be a sequence of length 1
            prev[i] = -1;

            for (int j = 0; j < i; j++)
            {
                if (arr[j] < arr[i] && dp[j] + 1 > dp[i])
                {
                    dp[i] = dp[j] + 1;
                    prev[i] = j;
                }
            }

            if (dp[i] > maxLength)
            {
                maxLength = dp[i];
                lastIndex = i;
            }
        }

        // Reconstruct LIS
        List<int> lis = new List<int>();
        while (lastIndex != -1)
        {
            lis.Add(arr[lastIndex]);
            lastIndex = prev[lastIndex];
        }
        lis.Reverse();

        Console.Write("Maximal increasing sequence: ");
        foreach (int num in lis)
        {
            Console.Write(num + " ");
        }
    }
}
