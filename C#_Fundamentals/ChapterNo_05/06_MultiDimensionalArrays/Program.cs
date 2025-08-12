using System;

class Program
{
    public static void Main(string[] args)
    {
        int[,,] arrays = {
        {
          {1, 2, 3, 4},
          {5, 6, 7, 8},
          {9, 10, 11, 12}
        },
         {   // Layer 1
                { 13, 14, 15, 16 },
                { 17, 18, 19, 20 },
                { 21, 22, 23, 24 }
            }
        };
        for (int i = 0; i < arrays.GetLength(0); i++)
        {
            for (int j = 0; j < arrays.GetLength(1); j++)
            {
                for (int k = 0; k < arrays.GetLength(2); k++)
                {
                    Console.Write(arrays[i, j, k]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}