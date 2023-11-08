using System.Xml.Linq;
using System;

public class DoubleLinkedList
{
    public Node Head { get; private set; }
    public Node Tail { get; private set; }

    public DoubleLinkedList()
    {
        Head = null;
        Tail = null;
    }

    public void Add(int data)
    {
        var newNode = new Node(data);

        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Previous = Tail;
            Tail.Next = newNode;
            Tail = newNode;
        }
    }

    public void Display()
    {
        Node current = Head;
        while (current != null)
        {
            Console.Write(current.Data + " <-> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}
