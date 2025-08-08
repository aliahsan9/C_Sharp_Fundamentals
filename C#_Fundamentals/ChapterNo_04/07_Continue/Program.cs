using System;

class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Enter any integer:");
        int num = int.Parse(Console.ReadLine());

        int sum = 0;
        for(int i = 1; i <= num; i += 2)
        {
            if(i % 7 == 0)
            {
                continue;
            }
            sum += i;
        }
        Console.WriteLine($"Sum of all Odd Integers is: {sum}");
    }
}