using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
{
    Console.WriteLine("Enter an integers, by separating commas:");
    string input = Console.ReadLine();

    int[] nums = input.Split(',')
    .Select (s => int.Parse(s.Trim()))
    .ToArray();

    for(int i = 0; i < nums.Length; i++)
    {
        int squareRoot = nums[i] * nums[i];

        Console.WriteLine($"SquareRoot of {nums[i]} is {squareRoot}");
    }
}
}