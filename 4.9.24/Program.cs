namespace _4._9._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> LinkedList = new DoublyLinkedList<int>();
            LinkedList.InsertFront(1);
            LinkedList.InsertFront(2);
            LinkedList.InsertFront(10);
            LinkedList.InsertFront(6);
            LinkedList.InsertLast(25);
            LinkedList.PrintList();
            Console.WriteLine("Middle Node: "+LinkedList.FindMiddleNode());
        }
    }
}
