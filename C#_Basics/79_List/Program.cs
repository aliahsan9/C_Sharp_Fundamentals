using System;

class Program
{
    public static void Main(string[] args)
    {
        List<int> nums = new List<int>();

        nums.Add(10);
        nums.Add(20);

        nums.Remove(10);
        foreach (int num in nums)
        {
            Console.WriteLine(num);
        }

    }
}
