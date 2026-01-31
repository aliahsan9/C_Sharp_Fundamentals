using System;

class FibonacciNumbers
{
    static void Main(String[] args)
    {
        int nums = 10;
        int a = 0, b = 1; // First Two Fibonacci Numbers

        Console.WriteLine("Fibonacci Numbers:");
        for(int i = 0; i <= nums; i++)
        {
            Console.Write(a + " ");

            int next = a + b;   // 0 + 1 = 1 then 1 + 2 = 3 ...

            //Move b into a
            a = b;         
            
            // Move next into b
            b = next;          
            
        }
    }
}