using System;

class Node
{
    public int Data;
    public Node Next;

    // Constructor
    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

//linked list 
class LinkedList
{
    public Node Head;

    //Add a new Node at the end of the Linekd List
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
    //Print all nodes of the linked list
    public void PrintList()
    {
        Node temp = Head;
        while(temp != null)
        {
            Console.Write(temp.Data+ " -> ");
            temp = temp.Next;
        }
        Console.WriteLine("null");
    }
}
//Main program
class program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.Add(10);
        list.Add(20);
        list.Add(30);

        list.PrintList();
    }
}