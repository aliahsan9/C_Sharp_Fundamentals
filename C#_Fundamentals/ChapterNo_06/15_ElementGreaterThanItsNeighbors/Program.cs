using System;

class Program
{
    // Method to check if element is greater than its neighbors
    static bool IsGreaterThanNeighbors(int[] arr, int position)
    {
        if (position <= 0 || position >= arr.Length - 1)
            return false; // no two neighbors at edges

        return arr[position] > arr[position - 1] && arr[position] > arr[position + 1];
    }

    static void Main()
    {
        int[] arr = { 1, 3, 5, 4, 2, 7, 6 };
        Console.Write("Enter position: ");
        int pos = int.Parse(Console.ReadLine());

        Console.WriteLine(IsGreaterThanNeighbors(arr, pos)
            ? $"Element at position {pos} is greater than its neighbors."
            : $"Element at position {pos} is NOT greater than its neighbors.");
    }
}
