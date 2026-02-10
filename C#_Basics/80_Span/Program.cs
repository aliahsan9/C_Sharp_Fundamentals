using System;

class Program
{
    static void Main(String[] args)
    {
        int[] nums = { 10, 20, 30, 40, 50 };

        Span<int> span = nums;

        span[0] = 70;

        foreach(var num in nums)
        {
            Console.WriteLine(num);
        }
        Span<int> slice = span.Slice(1, 3);

        foreach(var num in slice)
        {
            Console.WriteLine(num);
        }
    }
}