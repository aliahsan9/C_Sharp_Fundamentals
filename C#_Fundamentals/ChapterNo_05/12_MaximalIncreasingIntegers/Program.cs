using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] array = {1, 2, 2, 3, 4, 5, 6, 7};

        int start = 0;          // Start of window
        int maxStart = 0;       // Start of longest sequence
        int maxLength = 1;      // Length of longest sequence

        for (int end = 1; end < array.Length; end++)
        {
            // If sequence breaks, move start of the window to current index
            if (array[end] <= array[end - 1])
            {
                start = end;
            }

            int windowLength = end - start + 1;

            // Update maximum if we found a longer window
            if (windowLength > maxLength)
            {
                maxLength = windowLength;
                maxStart = start;
            }
        }

        Console.Write("Maximal increasing sequence: ");
        for (int i = maxStart; i < maxStart + maxLength; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
