using System;

class Program
{
    static int GetFibonacci(int num)
    {
        //Base Case
        if(num <= 2)
        {
            return 1;
        }
        return GetFibonacci(num - 1) + GetFibonacci(num - 2);
    }
    static void Main(String[] args)
    {
        int num = 10;
        Console.Write($"Fibonacci Sum of {num} is: {GetFibonacci(num)}");
    }
}