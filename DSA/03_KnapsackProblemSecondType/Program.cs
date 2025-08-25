using System;

class Program
{
    static void Main()
    {
        int[] values = { 60, 100, 120 };
        int[] weights = { 10, 20, 30 };
        int n = values.Length;
        int W = 50;

        int[,] dp = new int[n + 1, W + 1];

        for (int i = 0; i <= n; i++)
        {
            for (int w = 0; w <= W; w++)
            {
                if (i == 0 || w == 0)
                    dp[i, w] = 0;
                else if (weights[i - 1] <= w)
                    dp[i, w] = Math.Max(values[i - 1] + dp[i - 1, w - weights[i - 1]], dp[i - 1, w]);
                else
                    dp[i, w] = dp[i - 1, w];
            }
        }

        Console.WriteLine("Maximum value in 0/1 knapsack: " + dp[n, W]);
    }
}
