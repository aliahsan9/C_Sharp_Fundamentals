using System;

class Coins
{
    public static void PrintCoins(int[] coins, int V)
    {
        int count = 0;

        for (int i = 0; i < coins.Length; i++)
        {
            while (V >= coins[i])
            {
                V -= coins[i];
                count++;
                Console.Write(coins[i] + " "); // show which coins are used
            }
        }

        Console.WriteLine("\nMinimum coins needed: " + count);
    }

    static void Main(string[] args)
    {
        int[] coins = { 25, 10, 5, 1 };
        int V = 36;

        PrintCoins(coins, V);
    }
}
