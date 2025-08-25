using System;

class Program
{
    static int GetFactorial(int n)
    {
        int result = 1;

        for(int i = 1; i <= n; i++)
        {
            result*=i;
        }
        return result;
    }
    static void Main(String[] args)
    {
        Console.Write("Enter any integer to check it's factorial:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"Factorial of {num} is: {GetFactorial(num)}");
    }
}