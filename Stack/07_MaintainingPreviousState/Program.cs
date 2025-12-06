using System;
using System.Collections.Generic;

class UndoDemo
{
    static void Main()
    {
        Stack<string> history = new Stack<string>();
        string text = "";

        while (true)
        {
            Console.WriteLine($"\nCurrent Text: {text}");
            Console.WriteLine("1. Type new text");
            Console.WriteLine("2. Undo");
            Console.WriteLine("3. Exit");
            Console.Write("Choose option: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                // Save current state before change
                history.Push(text);

                Console.Write("Enter new text: ");
                text = Console.ReadLine();
            }
            else if (option == 2)
            {
                if (history.Count > 0)
                {
                    text = history.Pop();   // Go back to previous state
                }
                else
                {
                    Console.WriteLine("No previous state to undo!");
                }
            }
            else
            {
                break;
            }
        }
    }
}
