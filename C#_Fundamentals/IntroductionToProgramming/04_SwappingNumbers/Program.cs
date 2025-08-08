using System;

class Program
{
    public static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 10;

        Console.WriteLine($"Before Swapping: num1 = {num1} , num2 = {num2} ");

        int temp = num1;
        num1 = num2; 
        num2 = temp;

        Console.WriteLine($"After Swapping: num1 = {num1}, num2 = {num2}");
    }
}