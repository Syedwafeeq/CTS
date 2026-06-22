using System;

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

class CircularSinglyLinkedList
{
    Node head = null;

    public void Insert(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
            head.Next = head;
            return;
        }

        Node temp = head;

        while (temp.Next != head)
        {
            temp = temp.Next;
        }

        temp.Next = newNode;
        newNode.Next = head;
    }

    public void Traverse()
    {
        if (head == null)
            return;

        Node temp = head;

        do
        {
            Console.Write(temp.Data + " -> ");
            temp = temp.Next;
        }
        while (temp != head);

        Console.WriteLine("(head)");
    }

    static void Main()
    {
        CircularSinglyLinkedList list =
            new CircularSinglyLinkedList();

        list.Insert(10);
        list.Insert(20);
        list.Insert(30);

        list.Traverse();
    }
}
