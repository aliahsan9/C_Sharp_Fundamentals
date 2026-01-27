using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        // Left Rotation
        LeftRotate(arr, 2);
        Console.WriteLine("\nAfter Left Rotation by 2:");
        PrintArray(arr);

        // Right Rotation
        RightRotate(arr, 2);
        Console.WriteLine("\nAfter Right Rotation by 2:");
        PrintArray(arr);
    }

    // LEFT ROTATE FUNCTION
    static void LeftRotate(int[] arr, int k)
    {
        int n = arr.Length;
        k = k % n;

        Reverse(arr, 0, k - 1);
        Reverse(arr, k, n - 1);
        Reverse(arr, 0, n - 1);
    }

    // RIGHT ROTATE FUNCTION
    static void RightRotate(int[] arr, int k)
    {
        int n = arr.Length;
        k = k % n;

        Reverse(arr, 0, n - 1);
        Reverse(arr, 0, k - 1);
        Reverse(arr, k, n - 1);
    }

    // REVERSE HELPER FUNCTION
    static void Reverse(int[] arr, int start, int end)
    {
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }

    // PRINT ARRAY
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
