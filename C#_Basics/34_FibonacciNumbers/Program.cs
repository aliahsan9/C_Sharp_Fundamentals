using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        int nums = 10;
        int a = 0, b = 1;

        // Fibonacci Series
        Console.WriteLine("Fibonacci Series is:");
        for(int i = 0; i< nums; i++)
        {
            Console.Write(a + " ");

            int next = a + b;
            a = b;
            b = next;
        }
    }
}