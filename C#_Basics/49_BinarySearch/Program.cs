using System;

class BinarySearchProgram
{
    public static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while(left <= right)
        {
            int mid = left + (right - left);

            if (arr[mid] == target)
                return mid;
            else
                if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int target = 4;

        int result = BinarySearchProgram.BinarySearch(array, target);
        if(result != -1)
        {
            Console.WriteLine("Element Found at Index: "+ result);
        }
        else
        {
            Console.WriteLine("Target Not Found!");
        }
    }
}