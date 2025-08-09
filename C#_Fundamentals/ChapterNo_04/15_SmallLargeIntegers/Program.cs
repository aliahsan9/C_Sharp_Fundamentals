using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any Integers(separated with spaces):");
        string input = Console.ReadLine();

        int[] nums = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(s => int.Parse(s))
        .ToArray();

        int maxNum = nums.Max();
        int minNum = nums.Min();
        Console.WriteLine($"Maximum Integers in given Integers is: {maxNum}");
        Console.WriteLine($"Minimum Integers in given Integers is: {minNum}");
    }
}