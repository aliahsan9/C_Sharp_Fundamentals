using System;

class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Enter num1:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter num2:");
        int num2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Greatest number is:" + ((num1 > num2 ? num1 : num2)));
    }
}