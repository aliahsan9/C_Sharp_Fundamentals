using System;

class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Enter any integer:");
        int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Table of {num} is:");

        int i = 1;
        while (i <= 10)
        {
            Console.WriteLine($"{num} * {i} = " + num * i);
            i++;
        }
    }
}