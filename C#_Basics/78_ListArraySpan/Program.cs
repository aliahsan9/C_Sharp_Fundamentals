using System;

class Program
{
    public static void Main(String[] args)
    {
        int[] array = new int[3];
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;

        foreach(int num in array)
        {
            
            Console.WriteLine("Array Elements are:"+ num);
        }
    }
}