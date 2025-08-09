using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number n:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
    }
}