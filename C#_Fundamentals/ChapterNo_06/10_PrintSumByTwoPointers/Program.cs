using System;

class Program
{
    static bool HasPairWithSum(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int sum = arr[left] + arr[right];

            if (sum == target)
                return true;
            else if (sum < target)
                left++;
            else
                right--;
        }
        return false;
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 6 };
        Console.WriteLine(HasPairWithSum(numbers, 9));  // True (3+6)
        Console.WriteLine(HasPairWithSum(numbers, 20)); // False
    }
}
