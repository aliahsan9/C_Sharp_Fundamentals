using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer n:");
        int N = int.Parse(Console.ReadLine().Trim());

        //Create an array to store numbers
        int[] numbers = Enumerable.Range(1, N).ToArray();

        //Shuffle the integers using Fisher-yates algorithm
        Random rand = new Random();
        for (int i = numbers.Length - 1; i > 0; i--)
        {
            int j = rand.Next(0, i + 1);
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
        Console.WriteLine("Random numbers are:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}