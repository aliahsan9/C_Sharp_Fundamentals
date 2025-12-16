using System;

class CircularQueue
{
    private int[] queue;
    private int front, rear, size, capacity;

    // Constructor
    public CircularQueue(int capacity)
    {
        this.capacity = capacity;
        queue = new int[capacity];
        front = -1;
        rear = -1;
        size = 0;
    }

    // Check if queue is empty
    public bool IsEmpty()
    {
        return size == 0;
    }

    // Check if queue is full
    public bool IsFull()
    {
        return size == capacity;
    }

    // Enqueue operation
    public void Enqueue(int value)
    {
        if (IsFull())
        {
            Console.WriteLine("Queue is FULL!");
            return;
        }

        if (IsEmpty())
            front = 0;

        rear = (rear + 1) % capacity;
        queue[rear] = value;
        size++;

        Console.WriteLine($"{value} enqueued");
    }

    // Dequeue operation
    public void Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is EMPTY!");
            return;
        }

        int removed = queue[front];
        front = (front + 1) % capacity;
        size--;

        // Reset when queue becomes empty
        if (size == 0)
        {
            front = -1;
            rear = -1;
        }

        Console.WriteLine($"{removed} dequeued");
    }

    // Peek front element
    public void Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is EMPTY!");
            return;
        }

        Console.WriteLine("Front element: " + queue[front]);
    }

    // Display queue elements
    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is EMPTY!");
            return;
        }

        Console.Write("Queue elements: ");
        int index = front;

        for (int i = 0; i < size; i++)
        {
            Console.Write(queue[index] + " ");
            index = (index + 1) % capacity;
        }
        Console.WriteLine();
    }
}

// Test the Circular Queue
class Program
{
    static void Main()
    {
        CircularQueue cq = new CircularQueue(5);

        cq.Enqueue(10);
        cq.Enqueue(20);
        cq.Enqueue(30);
        cq.Enqueue(40);
        cq.Enqueue(50);

        cq.Display();

        cq.Dequeue();
        cq.Dequeue();

        cq.Display();

        cq.Enqueue(60);
        cq.Enqueue(70);

        cq.Display();

        cq.Peek();
    }
}
