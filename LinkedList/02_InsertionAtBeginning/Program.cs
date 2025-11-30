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
//Linked list
class LinkedList()
{
    public Node Head;
  // Insert new node at the beginning
    public void Add(int data)
    {
        Node newNode = new Node(data);  // create new node

        newNode.Next = Head;            // point new node to current head

        Head = newNode;                 // update head to the new node
    }

    //Print all nodes of a linked list 
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
class program{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);

        list.PrintList();
    }
}