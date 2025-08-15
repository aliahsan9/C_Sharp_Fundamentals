using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 2, 3, 4, 5, 6, 6, 6 };

        int maxCount = 1;
        int currentCount = 1;
        int number = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                currentCount++;
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    number = array[i];
                }
            }
            else
            {
                currentCount = 1;
            }
        }
        Console.WriteLine("Maximal Sequence is:");
        for (int i = 0; i < currentCount; i++)
        {
            Console.Write(number+ " ");
        }
    }
}