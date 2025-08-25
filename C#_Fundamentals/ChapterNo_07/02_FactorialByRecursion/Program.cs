using System;

class Program
{
    static int GetFactorial(int n)
    {
        // Base Case
        if(n == 0)
        {
            return 1;
        }
        return n* GetFactorial(n - 1);
    }
    static void Main(String[] args)
    {
        Console.Write("Enter any integer to get factorial:");
        int num = int.Parse(Console.ReadLine());
        Console.Write(GetFactorial(num));
    }
}