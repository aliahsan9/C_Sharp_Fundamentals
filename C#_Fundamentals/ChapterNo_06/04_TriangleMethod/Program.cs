using System;

class Program
{
    static void PrintTriangle(int[] nums)
    {
        int n = nums.Length;
        for(int i = 0; i <= n; i++)
        {
          for(int j = 0; j < i; j++)
          {
            Console.Write(nums[j] + " ");
          }
          Console.WriteLine();
        }
    }
    public static void Main(string[] args)
    {
        int[] nums = {1, 2, 3, 4, 5};
        PrintTriangle(nums);
    }
}