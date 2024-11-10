using System;

namespace LinkedListExamples
{
    // Singly Linked List Node and Operations
    public class SNode
    {
        public int Data;
        public SNode Next;
        public SNode(int data) { Data = data; Next = null; }
    }

    public class SinglyLinkedList
    {
        public SNode Head;

        public void InsertEnd(int data)
        {
            SNode newNode = new SNode(data);
            if (Head == null) Head = newNode;
            else
            {
                SNode temp = Head;
                while (temp.Next != null) temp = temp.Next;
                temp.Next = newNode;
            }
        }

        public void DeleteBeginning()
        {
            if (Head != null) Head = Head.Next;
        }

        public void Traverse()
        {
            SNode temp = Head;
            while (temp != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.Next;
            }
            Console.WriteLine("null");
        }
    }

    // Doubly Linked List Node and Operations
    public class DNode
    {
        public int Data;
        public DNode Next, Prev;
        public DNode(int data) { Data = data; Next = Prev = null; }
    }

    public class DoublyLinkedList
    {
        public DNode Head;

        public void InsertEnd(int data)
        {
            DNode newNode = new DNode(data);
            if (Head == null) Head = newNode;
            else
            {
                DNode temp = Head;
                while (temp.Next != null) temp = temp.Next;
                temp.Next = newNode;
                newNode.Prev = temp;
            }
        }

        public void DeleteBeginning()
        {
            if (Head != null) Head = Head.Next;
            if (Head != null) Head.Prev = null;
        }

        public void Traverse()
        {
            DNode temp = Head;
            while (temp != null)
            {
                Console.Write(temp.Data + " <-> ");
                temp = temp.Next;
            }
            Console.WriteLine("null");
        }
    }

    // Circular Linked List Node and Operations
    public class CNode
    {
        public int Data;
        public CNode Next;
        public CNode(int data) { Data = data; Next = null; }
    }

    public class CircularLinkedList
    {
        public CNode Head;

        public void InsertEnd(int data)
        {
            CNode newNode = new CNode(data);
            if (Head == null)
            {
                Head = newNode;
                newNode.Next = Head;
            }
            else
            {
                CNode temp = Head;
                while (temp.Next != Head) temp = temp.Next;
                temp.Next = newNode;
                newNode.Next = Head;
            }
        }

        public void DeleteBeginning()
        {
            if (Head != null)
            {
                if (Head.Next == Head) Head = null; // Only one node
                else
                {
                    CNode temp = Head;
                    while (temp.Next != Head) temp = temp.Next;
                    temp.Next = Head.Next;
                    Head = Head.Next;
                }
            }
        }

        public void Traverse()
        {
            if (Head == null) return;
            CNode temp = Head;
            do
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.Next;
            } while (temp != Head);
            Console.WriteLine("Head");
        }
    }

    // Doubly Circular Linked List Node and Operations
    public class DCNode
    {
        public int Data;
        public DCNode Next, Prev;
        public DCNode(int data) { Data = data; Next = Prev = null; }
    }

    public class DoublyCircularLinkedList
    {
        public DCNode Head;

        public void InsertEnd(int data)
        {
            DCNode newNode = new DCNode(data);
            if (Head == null)
            {
                Head = newNode;
                newNode.Next = newNode;
                newNode.Prev = newNode;
            }
            else
            {
                DCNode tail = Head.Prev;
                tail.Next = newNode;
                newNode.Prev = tail;
                newNode.Next = Head;
                Head.Prev = newNode;
            }
        }

        public void DeleteBeginning()
        {
            if (Head != null)
            {
                if (Head.Next == Head) Head = null; // Only one node
                else
                {
                    DCNode tail = Head.Prev;
                    Head = Head.Next;
                    Head.Prev = tail;
                    tail.Next = Head;
                }
            }
        }

        public void Traverse()
        {
            if (Head == null) return;
            DCNode temp = Head;
            do
            {
                Console.Write(temp.Data + " <-> ");
                temp = temp.Next;
            } while (temp != Head);
            Console.WriteLine("Head");
        }
    }

    class Program
    {
        static void Main()
        {
            // Singly Linked List Example
            var singlyList = new SinglyLinkedList();
            singlyList.InsertEnd(1);
            singlyList.InsertEnd(2);
            singlyList.InsertEnd(3);
            singlyList.Traverse(); // Output: 1 -> 2 -> 3 -> null

            // Doubly Linked List Example
            var doublyList = new DoublyLinkedList();
            doublyList.InsertEnd(1);
            doublyList.InsertEnd(2);
            doublyList.InsertEnd(3);
            doublyList.Traverse(); // Output: 1 <-> 2 <-> 3 <-> null

            // Circular Linked List Example
            var circularList = new CircularLinkedList();
            circularList.InsertEnd(1);
            circularList.InsertEnd(2);
            circularList.InsertEnd(3);
            circularList.Traverse(); // Output: 1 -> 2 -> 3 -> Head

            // Doubly Circular Linked List Example
            var doublyCircularList = new DoublyCircularLinkedList();
            doublyCircularList.InsertEnd(1);
            doublyCircularList.InsertEnd(2);
            doublyCircularList.InsertEnd(3);
            doublyCircularList.Traverse(); // Output: 1 <-> 2 <-> 3 <-> Head
        }
    }
}
