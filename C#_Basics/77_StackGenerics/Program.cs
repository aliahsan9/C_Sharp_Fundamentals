using System;

// Generic stack class
public class MyStack<T>
{
    private T[] items;   // Array to store stack elements
    private int top;     // Points to the top element
    private int capacity; // Maximum size of stack

    // Constructor
    public MyStack(int size)
    {
        capacity = size;
        items = new T[capacity];
        top = -1; // Stack is empty initially now 
    }

    // Push method: adds element to stack
    public void Push(T item)
    {
        // Check if stack is full
        if (top == capacity - 1)
        {
            Console.WriteLine("Stack Overflow");
            return;
        }

        // Move top pointer up
        top++;

        // Insert item
        items[top] = item;

        Console.WriteLine($"Pushed: {item}");
    }

    // Pop method: removes top element
    public T Pop()
    {
        // Check if stack is empty
        if (top == -1)
        {
            throw new InvalidOperationException("Stack Underflow");
        }

        // Get top element
        T item = items[top];

        // Move top pointer down
        top--;

        return item;
    }

    // Peek method: returns top element without removing
    public T Peek()
    {
        if (top == -1)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return items[top];
    }

    // Check if stack is empty
    public bool IsEmpty()
    {
        return top == -1;
    }

    // Get number of elements
    public int Count()
    {
        return top + 1;
    }
}

class Program
{
    static void Main()
    {
        // Create a stack of integers
        MyStack<int> intStack = new MyStack<int>(5);

        intStack.Push(10);
        intStack.Push(20);
        intStack.Push(30);

        Console.WriteLine("Top element: " + intStack.Peek());

        Console.WriteLine("Popped: " + intStack.Pop());
        Console.WriteLine("Popped: " + intStack.Pop());

        Console.WriteLine("Stack count: " + intStack.Count());

        // Create a stack of strings
        MyStack<string> stringStack = new MyStack<string>(3);

        stringStack.Push("A");
        stringStack.Push("B");

        Console.WriteLine("Top string: " + stringStack.Peek());
    }
}
