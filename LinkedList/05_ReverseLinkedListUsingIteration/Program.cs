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

    //Add function to add nodes, in an empty list
    public void Add(int data)
    {
        Node newNode = new Node(data);

        if(Head == null)
        {
            Head = newNode;
            return;
        }

        Node temp = Head;
        while(temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    //Function to Reverse the whole Linkedlist
    public void ReverseIterative()
    {
        Node prev = null;
        Node current = Head;
        Node Next = null;

        while(current != null)
        {
            Next = current.Next;
            current.Next = prev;

            prev = current;
            current = Next;
        }
        Head = prev;
    }
    //Print the all nodes, of list
    public void PrintList()
    {
        Node temp = Head;

        while(temp != null)
        {
            Console.Write(temp.Data + " -> ");
            temp = temp.Next;
        }
        Console.WriteLine("null");
    }
}
class Program
{
    static void Main(String[] args)
    {
        LinkedList list = new LinkedList();

        list.Add(10);
        list.Add(20);
        list.Add(30);
        
        Console.WriteLine("Linked List before Reverse Method: ");
        list.PrintList();
        list.ReverseIterative();
        Console.WriteLine("Linked List after Reverse Method:");
        list.PrintList();
    }
}