using System;
using System.Collections.Generic;

class ManualRecursion
{
    public static int RecursionStack(int n)
    {

        Stack<int> stack = new Stack<int>();
        // push n into stack
        while(n > 1)
        {
            stack.Push(n);
            n--;
        }
        int result = 1;

        while(stack.Count > 0)
        {
            result *= stack.Pop();
        }
        return result;
    }
    static void Main(string[]args)
    {
        Console.WriteLine("Factorial of given number is: " + RecursionStack(5));
    }
}