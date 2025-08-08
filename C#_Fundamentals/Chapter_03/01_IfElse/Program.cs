using System;

class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Enter first number:");
        int fitstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a second number:");
        int secondNumber = int.Parse(Console.ReadLine());

       if(fitstNumber > secondNumber)
       {
        Console.WriteLine("First Number is greater.");
       }
       else if(secondNumber > fitstNumber)
       {
        Console.WriteLine("Second Number is greater.");
       }else
       {
        Console.WriteLine("Both are equal, or inValid Input!");
       }
    }
} 