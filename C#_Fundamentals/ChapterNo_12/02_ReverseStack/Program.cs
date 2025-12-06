using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter how many numbers (N): ");
        int n = int.Parse(Console.ReadLine());

        Stack<int> stack = new Stack<int>();

        Console.WriteLine($"Enter {n} integers:");

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            stack.Push(num);  // add to stack
        }

        Console.WriteLine("\nNumbers in reversed order:");
        while (stack.Count > 0)
        {
            Console.Write(stack.Pop() + " ");
        }
    }
}
