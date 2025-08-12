using System;

class Program
{
    public static void Main(string[] args)
    {
        // Declare a jagged array (array of arrays)
        int[][] jagged = new int[3][]; // 3 rows, but columns not yet defined

        // Initialize each row with different column sizes
        jagged[0] = new int[] { 1, 2, 3 };           // 3 columns
        jagged[1] = new int[] { 4, 5 };              // 2 columns
        jagged[2] = new int[] { 6, 7, 8, 9, 10 };    // 5 columns

        Console.WriteLine("Jagged Array Elements:");
        for (int row = 0; row < jagged.Length; row++) // jagged.Length → number of rows
        {
            for (int col = 0; col < jagged[row].Length; col++) // jagged[row].Length → number of columns in that row
            {
                Console.Write(jagged[row][col] + " ");
            }
            Console.WriteLine();
        }
    }
}
