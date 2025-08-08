using System;

class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Enter value of n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of m:");
        int m = int.Parse(Console.ReadLine());

        decimal result = 1;
        for(int i = 0; i < m; i++)
        {
            result *= n;
        }
        Console.WriteLine("n^m: "+ result);
    }  
}