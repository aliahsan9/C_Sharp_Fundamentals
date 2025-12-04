using System;

class Stack
{
    private int[] items;
    private int top;
    private int maxSize;

    //Constructor
    public Stack(int size)
    {
        maxSize = size;
        items = new int[maxSize];
        top = -1; //Stack is empty
    }
    //Push -> Add elements
    public void Push(int val)
    {
        if(top == maxSize - 1)
        {
            Console.WriteLine("Stack Overflow!");
            return;
        }
        items[++top] = val;
    }
    //Pop -> remove element
    public int Pop()
    {
        if(top == -1)
        {
            Console.WriteLine("Stack Overflow!");
            return -1;
        }
        return items[top--];
    }
    //Peek -> check top elements
    public int Peek()
    {
        if(top == -1)
        {
            Console.WriteLine("Stack is empty!");
            return -1;
        }
        return items[top];
    }
    //Display -> Print Stack elements
    public void Display()
    {
        if(top == -1)
        {
            Console.WriteLine("Stack is empty!");
            return;
        }
        Console.WriteLine("Stack elements are:");
       for(int i = top; i>= 0; i--)
        {
            Console.WriteLine(items[i]);
        }
    }
}
class Program
{
    static void Main(String[] args)
    {
        Stack st = new Stack(5);

        st.Push(10);
        st.Push(20);
        st.Push(30);

        Console.WriteLine("Top elements are:");
        st.Display();

        st.Pop();
        Console.WriteLine("After Poping elements are:");
        st.Display();
        
    }
}