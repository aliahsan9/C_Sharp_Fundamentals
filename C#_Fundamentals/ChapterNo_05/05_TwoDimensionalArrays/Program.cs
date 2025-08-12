using System;

class Program
{
    public static void Main(String[] args)
    {
        int[,] array = {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 }
        };
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.Write(array[row , col] + " ");
            }
            Console.WriteLine();
        }

    }
}