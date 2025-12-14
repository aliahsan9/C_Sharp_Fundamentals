using System;
using System.Collections.Generic;

class PrimeNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter any Number:");
        int num = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if(num <= 1)
        {
            isPrime = false;
        }
        else
        {
            for(int i = 2; i * i <= num; i++)
            {
                if(num % i == 0)
                isPrime = false;
                break;
            }
        }
    if(isPrime)
    Console.WriteLine($"{num} is Prime number.");
    else
    Console.WriteLine($"{num} is not a prime number.");
}
}