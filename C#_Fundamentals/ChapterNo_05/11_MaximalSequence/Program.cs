using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 1, 2, 3, 2, 2, 2, 1 };

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
                currentCount = 1; // reset for new sequence
            }
        }

        Console.Write("Maximal sequence: ");
        for (int i = 0; i < maxCount; i++)
        {
            Console.Write(number + " ");
        }
    }
}