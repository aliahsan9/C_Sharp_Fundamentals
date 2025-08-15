using System;

class Program
{
    static int PrintArray(int num1, int num2)
    {
        int product = num1 * num2;
        return product;
    }
    public static void Main(string[] args)
    {
        int num1 = 3, num2 = 5;
        int product = PrintArray(num1, num2);
        Console.WriteLine("Product of both numbers is:"+ product);
    }
}