//Here we will print the sum of maximun subarray from given array using Brutr force method

using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int n = array.Length;
        int maxSum = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            int currentSum = 0;
            for (int j = i; j < n; j++)
            {
                currentSum += array[j];
                maxSum = Math.Max(currentSum, maxSum);
            }
        }
        Console.Write(maxSum);
    }
}