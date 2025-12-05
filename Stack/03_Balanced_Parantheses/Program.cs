using System;
using System.Collections.Generic;

class BalancedParantheses
{
    public static bool IsBalanced(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach(char ch in input)
        {
            //If it's an opening bracket, push it in stack
            if(ch == '(' || ch == '{' || ch == '[')
            {
                stack.Push(ch);
            }
            //If it's closing bracket 
            else 
            if(ch == ')' || ch == '}' || ch == ']')
            {
                //if the stack is empty -> no opening bracket
                if(stack.Count == 0)
                {
                    return false;
                }
                char top = stack.Pop();

                //Check matching pairs
                if((ch == ')' && ch == '(') ||
                (ch == '}' && ch == '{') ||
                (ch == ']' && ch == '['))
                {
                    return false;
                }

            }
        }
        //Stack must be empty -> all brackets matched
        return stack.Count == 0;
    }
    static void Main(String[] args)
    {
        Console.Write("Enter Expression: ");
        string input = Console.ReadLine();

        Console.WriteLine(IsBalanced(input) ? "Balanced" : "Not Balanced");

    }
}