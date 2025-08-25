using System;

class Program
{
static void PrintReversedDigits(int number)
{
    while (number > 0)
    {
        Console.Write(number % 10);
        number /= 10;
    }
    Console.WriteLine();
}
    static void Main(string[] args)
    {
        int num = 123;
        Console.WriteLine("Reversed of given integer is:");
        PrintReversedDigits(num);
    }
}