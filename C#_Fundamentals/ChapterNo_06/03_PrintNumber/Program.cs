using System;

class Program
{
    static void PrintSign(int number)
    {
        if(number < 0)
        {
            Console.WriteLine("Given number is negative.");
        }
        else
        if(number > 0)
        {
            Console.WriteLine("Given Number is positive.");
        }
        else
        {
            Console.WriteLine("Given number is zero.");
        }
    }
    public static void Main(string[] args)
    {
        int num = 2;
        PrintSign(num);
    }
}