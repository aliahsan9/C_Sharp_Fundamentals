using System;

class CheckNumbers
{
    static void Main(string[] args)
    {
        int n = 13;

        if(n % 2 == 0)
        {
            Console.WriteLine($"{n} is Even Number.");
        }
        else
        {
            Console.WriteLine($"{n} is Odd Number.");
        }
        bool isPrime = false;
        if(n <= 0)
        {
            isPrime = false;
        }
        else
        {
            for(int i = 2; i<= n / 2;  i++)
            {
                if(n % i == 0)
                {
                    isPrime = false;
                }
            }
        }
        if (isPrime)
        {
            Console.WriteLine($"{n} is Prime");
        }
        else
        {
            Console.WriteLine($"{n} is Not Prime!");
        }
    }
}