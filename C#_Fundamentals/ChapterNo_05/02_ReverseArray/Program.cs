using System;

class Program
{
    public static void Main(string[] args)
{
    int[] array = {2, 3, 4, 5, 6};
    for(int i = array.Length - 1; i >= 0; i--)     
    {
        Console.Write(array[i] + " ");
    }
  }
}