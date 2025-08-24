using System;

class Program
{
    static int CountOccurences(int[] array, int number)
    {
        int count = 0;

        foreach (int val in array)
        {
            if (val == number)
            {
                count++;
            }
        }
        return count;
    }
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 4, 3, 3, 3 };
        Console.WriteLine("Entrer any integer to check it's occurrences in above array:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"Total occurences of {num} in above array are: {CountOccurences(array, num)}");
    }
}