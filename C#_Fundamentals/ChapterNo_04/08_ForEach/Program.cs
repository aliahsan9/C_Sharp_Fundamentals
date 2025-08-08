using System;

class Program
{
    public static void Main(string[]args)
    {
        int[] nums = {2, 3, 4, 5 ,6};
        foreach (int num in nums)
        {
         Console.Write(" " + num);
        }
        Console.WriteLine();
        string[] fruits = {"Apple", "Orange", "Banana"};
        foreach(string fruit in fruits)
        {
            Console.Write(" " + fruit);
        }
    }
}