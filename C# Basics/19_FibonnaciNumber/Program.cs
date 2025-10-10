using System;

class Program
{
    public static void Main(string[] args)
    {
        int n = 10;
        int a = 0, b = 1, next;
        Console.WriteLine("First 10 Fibonacci Numbers are:");

        Console.WriteLine(a + " " + b + " ");

        for (int i = 3; i <= n; i++)
        {
            next = a + b;
            Console.Write(next + " ");
            a = b;
            b = next;
        }
        Console.WriteLine();
    }
}