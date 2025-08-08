using System;

class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Enter any Integer");
        int num = int.Parse(Console.ReadLine());
        for(int row = 1; row <= num; row++)
        {
            for(int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }
    }
}