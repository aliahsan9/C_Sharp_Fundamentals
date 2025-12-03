using System;

class Node
{
    public int Data;
    public Node Next;

    //Constructor
    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    public Node Head;

    //Function to Add elements in a linked list
    public void Add(int data)
    {
        Node newNode = new Node(data);

        if (Head == null)
        {
            Head = newNode;
            return;
        }

        Node temp = Head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    //Recursive Approach to reverse the linked list
    public Node ReverseRecursive(Node head)
    {
        // Base case
        if (head == null || head.Next == null)
            return head;

        Node rest = ReverseRecursive(head.Next);
        head.Next.Next = head;
        head.Next = null;

        return rest;
    }

    // Helper function to call reverse
    public void Reverse()
    {
        Head = ReverseRecursive(Head);
    }

    // Print all nodes of a linked list
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

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        list.Add(10);
        list.Add(20);
        list.Add(30);

        Console.WriteLine("Linked List before Reversing:");
        list.PrintList();

        list.Reverse();

        Console.WriteLine("Linked List after Reversing (Recursive):");
        list.PrintList();
    }
}
