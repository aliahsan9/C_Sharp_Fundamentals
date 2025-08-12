using System;

class Program
{
    public static void Main(String[] args)
    {
        int[] array = new int[] {2, 3, 4, 5, 6};
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] * array[i];
            Console.Write(array[i]+ " ");
        }
    }
}