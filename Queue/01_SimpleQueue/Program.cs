using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> numbers = new Queue<int>();

       //Enqueue -> Add elements
        numbers.Enqueue(10);
        numbers.Enqueue(20);
        numbers.Enqueue(30);

        // Print Numbers after Enqueue 
        Console.WriteLine("Queue Elements are:");
        foreach(int n in numbers)
        {
           Console.WriteLine(n);
        }

        //Check first element without removing
        Console.WriteLine("\nPeek Elements: "+ numbers.Peek());

        //Dequeue -> Remove the first element
        Console.WriteLine("\nDequeue: "+ numbers.Dequeue());

        //Count all elements
        Console.WriteLine("\nTotal elements are:"+ numbers.Count());

        Console.WriteLine("\nQueue after Dequeue:");
        foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}