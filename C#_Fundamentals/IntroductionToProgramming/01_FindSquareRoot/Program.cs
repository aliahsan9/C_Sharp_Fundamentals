using System;
using System.Linq; // Required for .Select()

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter integers separated by commas (e.g., 2,3,4):");
        string input = Console.ReadLine();

        // Convert string input to int array
        int[] nums = input.Split(',')
                          .Select(s => int.Parse(s.Trim()))
                          .ToArray();

        // Calculate square of each number
        for (int i = 0; i < nums.Length; i++)
        {
            int square = nums[i] * nums[i];
            Console.WriteLine($"Square of {nums[i]} is {square}");
        }
    }
}