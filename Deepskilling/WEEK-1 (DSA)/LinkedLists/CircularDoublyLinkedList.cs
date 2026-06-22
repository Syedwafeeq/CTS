using System;

class Node
{
    public int Data;
    public Node Next;
    public Node Prev;

    public Node(int data)
    {
        Data = data;
        Next = null;
        Prev = null;
    }
}

class CircularDoublyLinkedList
{
    Node head = null;

    public void Insert(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
            head.Next = head;
            head.Prev = head;
            return;
        }

        Node last = head.Prev;

        last.Next = newNode;
        newNode.Prev = last;
        newNode.Next = head;
        head.Prev = newNode;
    }

    public void Traverse()
    {
        if (head == null)
            return;

        Node temp = head;

        do
        {
            Console.Write(temp.Data + " <-> ");
            temp = temp.Next;
        }
        while (temp != head);

        Console.WriteLine("(head)");
    }

    static void Main()
    {
        CircularDoublyLinkedList list =
            new CircularDoublyLinkedList();

        list.Insert(10);
        list.Insert(20);
        list.Insert(30);

        list.Traverse();
    }
}
