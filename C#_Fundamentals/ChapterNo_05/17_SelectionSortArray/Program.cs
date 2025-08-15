using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 4, 5, 6, 10, 2, 1, 3, 7 };

        Console.WriteLine("Before Sorting:");
        PrintArray(array);
        SelectionSort(array);
        Console.WriteLine("After Sorting:");
        PrintArray(array);
    }

    static void SelectionSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
    }
    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

}