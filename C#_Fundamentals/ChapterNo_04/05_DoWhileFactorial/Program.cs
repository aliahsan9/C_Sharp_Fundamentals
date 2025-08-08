
using System;
using System.Numerics;
class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Enter any Integer:");
        int num = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        do
        {
            factorial *= num;
            num--;
        } while (num > 0);
        Console.WriteLine($"Factorial of {num} is: {factorial}");
    }
}