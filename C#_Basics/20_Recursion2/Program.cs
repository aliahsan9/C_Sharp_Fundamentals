using System;
using Microsoft.VisualBasic;

class Program
{
    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    static void Main(string[] args)
    {
        int n = 5;
        Console.WriteLine("Fibonacci numbers are:" + Fibonacci(n));
    }
}