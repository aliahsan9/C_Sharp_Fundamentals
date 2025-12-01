using System;

// Node class
class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

// LinkedList class
class LinkedList
{
    public Node Head;

    // Insert at any position (1-based index)
    public void AddAtPosition(int data, int position)
    {
        Node newNode = new Node(data);

        // Case 1: Insert at beginning
        if (position == 1)
        {
            newNode.Next = Head;
            Head = newNode;
            return;
        }

        // Case 2: Insert in middle or end
        Node temp = Head;
        int currentPos = 1;

        // Move to the node BEFORE the position
        while (temp != null && currentPos < position - 1)
        {
            temp = temp.Next;
            currentPos++;
        }

        // If position is greater than list length
        if (temp == null)
        {
            Console.WriteLine("Position out of range!");
            return;
        }

        // Insert node
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    // Print list
    public void PrintList()
    {
        Node temp = Head;

        while (temp != null)
        {
            Console.Write(temp.Data + " -> ");
            temp = temp.Next;
        }
        Console.WriteLine("null");
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        list.AddAtPosition(10, 1);  // Insert at pos 1
        list.AddAtPosition(20, 2);  // Insert at pos 2
        list.AddAtPosition(15, 2);  // Insert at pos 2 (middle)
        list.AddAtPosition(5, 1);   // Insert at start

        list.PrintList();
    }
}
