using System;
using System.Collections.Generic;
class PrimeNumbers
{
    public static int CheckPrime(int num)
    {

        if(num <= 1)
        {
            return 0; // Not Prime
        }
        for(int i = 2; i * i <= num; i++)
        {
            if(num % i == 0)
            {
                return 0; // Not Prime
            }
        }
        return 1; // prime
    }
}
class Program
{
    public static void Main()
    {
        int num = 4; //Initialize number 4 for testing
        if(PrimeNumbers.CheckPrime(num) == 1)
        {
            Console.WriteLine($"{num} is Prime Number!");
        }
        else
        {
            Console.WriteLine($"{num} is non-prime!");
        }
    }
}