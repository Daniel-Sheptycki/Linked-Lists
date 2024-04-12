using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._9._24
{
    internal class DoublyLinkedList<T>
    {
        public Node tail;
        public double Count;
        public DoublyLinkedList()
        {
            head = null;
            tail = null;
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
            node.Previous = null;
            node.Next = head;
            if (head == null)
            {
                tail = node;
            }
            head = node;
            Count++;
        }
        public void InsertLast(T value)
        {
            Node node = new Node(value);
            tail = node;
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
                node.Previous = current;
            }
            Count++;
        }
        public void DeleteNode(Node nodeToRemove)
        {
            if (nodeToRemove == head)
            {
                head = head.Next;
                head.Previous = null;
            } else if (nodeToRemove == tail)
            {
                tail.Previous.Next = null;
                tail = tail.Previous;
            } else
            {
                Node current = head;
                while (current != nodeToRemove)
                {
                    if (current.Next == null)
                    {
                        return;
                    }
                    current = current.Next;
                }
                current.Previous.Next = current.Next;
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
        public bool IsPalindrome(DoublyLinkedList<char> list)
        {
            Node head = list.head;
            for (int i = 0; i < Count / 2; i++)
            {

            }
            return false;
        }
    }
}
