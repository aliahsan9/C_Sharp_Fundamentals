using System;

class Program
{
    static void ReverseArray(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            // Swap
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            // Move pointers
            left++;
            right--;
        }
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        ReverseArray(numbers);

        Console.WriteLine(string.Join(", ", numbers)); // Output: 5, 4, 3, 2, 1
    }
}
