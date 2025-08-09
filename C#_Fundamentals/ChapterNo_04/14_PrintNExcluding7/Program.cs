using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter value of n:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 || i % 7 == 0)
            {
                continue;
            }
            Console.Write(i + " ");
        }
    }
}