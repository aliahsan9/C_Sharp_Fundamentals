using System;

class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Enter any Integer:");
        int num = int.Parse(Console.ReadLine());
       
       decimal factorial = 1;
       while (true)
       {
        if(num <= 1)
        {
            break;
        }
        factorial *= num;
        num--;
       }
       Console.WriteLine($"Factorial of {num} is: {factorial}");
    }
}