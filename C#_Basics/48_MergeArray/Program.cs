using System;

class Program
{
    static void Main()
    {
        int[] arr1 = { 1, 3, 5, 7 };
        int[] arr2 = { 2, 4, 6, 8 };

        int[] merged = MergeSortedArrays(arr1, arr2);

        Console.WriteLine("Merged Array:");
        PrintArray(merged);
    }

    static int[] MergeSortedArrays(int[] arr1, int[] arr2)
    {
        int n1 = arr1.Length;
        int n2 = arr2.Length;

        int[] result = new int[n1 + n2];

        int i = 0, j = 0, k = 0;

        // Compare and merge
        while (i < n1 && j < n2)
        {
            if (arr1[i] <= arr2[j])
                result[k++] = arr1[i++];
            else
                result[k++] = arr2[j++];
        }

        // Copy remaining elements
        while (i < n1)
            result[k++] = arr1[i++];

        while (j < n2)
            result[k++] = arr2[j++];

        return result;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
            Console.Write(num + " ");
        Console.WriteLine();
    }
}
