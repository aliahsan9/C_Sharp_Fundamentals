using System;

class Program
{
    // Method to find first index where element is greater than its neighbors
    static int FirstPeakPosition(int[] arr)
    {
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                return i;
        }
        return -1;
    }

    static void Main()
    {
        int[] arr = { 1, 3, 5, 4, 2, 7, 6 };
        int pos = FirstPeakPosition(arr);

        if (pos != -1)
            Console.WriteLine($"First peak element found at position {pos} (value = {arr[pos]})");
        else
            Console.WriteLine("No element greater than its two neighbors found.");
    }
}
