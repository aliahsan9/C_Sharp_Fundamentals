using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of an array:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
         
         Console.WriteLine("Enter an elements in an array:");
        for(int i = 0; i < n; i++)
        {
        array[i] = int.Parse(Console.ReadLine());
        }
        bool symmetric = true;
        for(int i = 0; i < array.Length / 2; i++)
        {
          if(array[i] != array[n - i -1])
          {
            symmetric = false;
            break;
          }
        }
        Console.WriteLine($"IsSymmetric: {symmetric}");

    }
}