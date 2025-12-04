using System;
using System.Collections.Generic;
class ReverseUsingStack
{
    public static string ReverseString(string input)
    {
        Stack<char> stack = new Stack<char>();

        //Push characters into the stack
        foreach(char ch in input)
        {
            stack.Push(ch);
        }

        //Pop characters to form the reverses string
        string reversed = "";
        while(stack.Count > 0)
        {
            reversed += stack.Pop();
        }
        return reversed;
    }
    static void Main(String[] args)
    {
        Console.WriteLine("Enter any String:");
        string str = Console.ReadLine();

        string output = ReverseString(str);
        Console.WriteLine("Reversed String is: "+ output);
        
        Console.ReadLine();
    }
}