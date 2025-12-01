using System;

class Node 
{
    public int Data;
    public Node Next;

    //Constructor
    public Node (int data)
    {
        Data = data;
        Next = null;
    }
}
// Linked List class
class LinkedList
{
    public Node Head;

    //Add Function to add nodes, in a linked list
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
    //Function to deletion from beginning nodes
   public void DeletionFromBeginning()
   {
     if(Head == null)
     {
        Console.WriteLine("List is empty, Nothing is to delete!");
        return;
     }
     Head = Head.Next;
     Console.WriteLine("Node from beginning is deleted!");
   }
    //Print all nodes, of given lineked list
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

        list.PrintList();
        list.DeletionFromBeginning();

        list.PrintList();
    }
}