using System;

class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Enter any integer:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Table of {num} is:");
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} * {i} = " + num * i);
        }
    }
}