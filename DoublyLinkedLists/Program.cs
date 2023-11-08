using System;

namespace DoublyLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList();

            doubleLinkedList.Add(10);
            doubleLinkedList.Add(20);
            doubleLinkedList.Add(30);
            doubleLinkedList.Add(40);

            Console.WriteLine("Doubly Linked List:");
            doubleLinkedList.Display();
        }
    }
}
