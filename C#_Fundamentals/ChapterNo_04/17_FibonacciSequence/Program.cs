using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any Integer:");
        int n = int.Parse(Console.ReadLine());

        long sum = 0;
        long first = 0, second = 1;

        for (int i = 0; i < n; i++) // Changed <= to <
        {
            sum += first;
            long next = first + second;
            first = second;
            second = next;
        }

        Console.WriteLine($"Sum of first {n} Fibonacci numbers is: {sum}");
    }
}
