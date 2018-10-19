using System;
using LinkedList.Classes;

namespace reverseLL
{
    public class Program
    {
        /// <summary>
        /// Reverse linked list in place
        /// </summary>
        /// <param name="llist">Linked list to reverse</param>
        /// <returns>Reversed linked list</returns>
        public static LList Reverse(LList llist)
        {
            llist.Current = llist.Head;
            Node temp = llist.Head;
            Node prev = null;
            while(llist.Current != null)
            {
                temp = llist.Current.Next;
                llist.Current.Next = prev;
                prev = llist.Current;
                llist.Current = temp;
            }
            llist.Head = prev;
            return llist;
        }

        static void Main(string[] args)
        {
            LList llToReverse = new LList(new Node(10));
            llToReverse.Add(9);
            llToReverse.Add(8);
            llToReverse.Add(7);
            Console.WriteLine("Initial linked list to reverse");
            llToReverse.Print();
            Reverse(llToReverse);
            Console.WriteLine();
            Console.WriteLine("Reversed linked list");
            llToReverse.Print();
            Console.ReadLine();
        }
    }
}
