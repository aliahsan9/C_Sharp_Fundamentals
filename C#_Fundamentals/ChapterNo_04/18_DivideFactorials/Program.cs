using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter value of N(ensure N > K > 1)");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of k (ensure N > k > 1)");
        int K = int.Parse(Console.ReadLine());


        if (K <= 1 || K >= N)
        {
            Console.WriteLine("Invalid Input! (ensure N > K > 1)");
            return;
        }
        long result = 1;

        for (int i = K + 1; i <= N; i++)
        {
            result *= i;
        }
        Console.WriteLine($"{N}! / {K}! = {result}");
    }
}