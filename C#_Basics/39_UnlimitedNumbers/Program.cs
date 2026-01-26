using System;

 class Program
{
        // Method Using Params
        static int sumNumbers(params int[] nums)
        {
            int sum = 0;
            foreach(int num in nums)
            {
                sum += num;
            }
            return sum;
        }

    static void Main(string[] args)
    {
        // Call the method with different number of arguments
        int result1 = sumNumbers(2, 3, 4);
        int result2 = sumNumbers(5, 7, 8);
        int result3 = sumNumbers(9, 5, 67, 7);

        Console.WriteLine("Sum2: " + result1);
        Console.WriteLine("Sum2: " + result2);
        Console.WriteLine("Sum3: " + result3);
    }
}
