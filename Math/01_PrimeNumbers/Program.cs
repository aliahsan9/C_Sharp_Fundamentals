using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (num <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
            Console.WriteLine($"{num} is a Prime Number");
        else
            Console.WriteLine($"{num} is NOT a Prime Number");
    }
}
