using System;

class Stack
{
    private int[] items;
    private int top;
    private int maxSize;

    public Stack(int size)
    {
        maxSize = size;
        items = new int[maxSize];
        top = -1; // stack is empty now
    }

    // Push → Add element
    public void Push(int value)
    {
        if (top == maxSize - 1)
        {
            Console.WriteLine("Stack Overflow!");
            return;
        }
        items[++top] = value;
    }

    // Pop → Remove top element
    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow!");
            return -1;
        }
        return items[top--];
    }

    // Peek → Check top element
    public int Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty!");
            return -1;
        }
        return items[top];
    }

    // Display → Print stack elements
    public void Display()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty!");
            return;
        }

        Console.WriteLine("Stack elements:");
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(items[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        Stack st = new Stack(5);

        st.Push(10);
        st.Push(20);
        st.Push(30);

        Console.WriteLine("Top element is: " + st.Peek());

        st.Display();

        Console.WriteLine("Popped: " + st.Pop());

        st.Display();

        Console.ReadLine();
    }
}
