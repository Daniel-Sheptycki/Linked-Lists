using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._9._24
{
    internal class SinglyLinkedList<T>
    {
        public class Node
        {
            public T Data { get; set; }
            public Node? Next {  get; set; }
            public Node(T data) 
            {
                Data = data;
                Next = null;
            }
                            
        }
        public Node head;
        public double Count;
        public SinglyLinkedList()
        {
            head = null;
            Count = 0;
        }
        public void PrintList()
        {
            bool noNextNode = false;
            string returnString = "";
            Node current = head;
            do
            {
                if (current.Next != null)
                {
                    returnString += $"[{current.Data}] -> ";
                    current = current.Next;
                }
                else
                {
                    returnString += $"[{current.Data}] -> NULL";
                    noNextNode = true;
                }
            }
            while (!noNextNode);
            Console.WriteLine(returnString);
        }
        public void InsertFront(T value)
        {
            Node node = new Node(value);
            node.Next = head;
            head = node;
            Count++;
        }
        public void InsertLast(T value)
        {
            Node node = new Node(value);
            if (head == null) 
            {
                head = node;
            } 
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
            Count++;
        }
        public void DeleteNode(Node nodeToRemove)
        {
            if (nodeToRemove == head)
            {
                head = head.Next;
            } else
            {
                Node current = head;
                while (current.Next != nodeToRemove)
                {
                    if (current.Next == null)
                    {
                        return;
                    }
                    current = current.Next;
                }
                current.Next = nodeToRemove.Next;
            }
            Count--;
        }
        public T FindMiddleNode()
        {
            Node current = head;
            for (int i = 0; i < Count / 2; i++)
            {
                if (i != 0)
                {
                    current = current.Next;
                }
            }
            return current.Data;
        }
    }
}
