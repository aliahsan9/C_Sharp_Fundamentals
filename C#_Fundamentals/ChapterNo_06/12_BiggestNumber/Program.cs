using System;

class Program
{
    static int GetMax(int num1, int num2)
    {
       return (num1 > num2) ? num1 : num2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter num1:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter num2:");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter num3:");
        int num3 = int.Parse(Console.ReadLine());

        int bigget = GetMax(GetMax(num1, num2), num3);
        Console.WriteLine($"Biggest number is: {bigget}");
    }
}