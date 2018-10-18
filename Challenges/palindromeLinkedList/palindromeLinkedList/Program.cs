using System;
using LinkedList.Classes;

namespace palindromeLinkedList
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
        /// <summary>
        /// Check whether given linked list is a palindrome or not
        /// </summary>
        /// <param name="llist">Linked list to check</param>
        /// <returns>bool. True - it's palindrome</returns>
        public static bool CheckPalindrome(LList llist)
        {
            LList llCopied = new LList(new Node(llist.Head.Value));
            llist.Current = llist.Current.Next;
            while(llist.Current != null)
            {
                llCopied.Add(llist.Current.Value);
                llist.Current = llist.Current.Next;
            }
            llist.Current = llist.Head;
            llCopied.Current = llCopied.Head;
            while(llist.Current != null)
            {
                if (llist.Current.Value.ToString() != llCopied.Current.Value.ToString()) return false;
                llist.Current = llist.Current.Next;
                llCopied.Current = llCopied.Current.Next;
            }
            return true;
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

            LList ll = new LList(new Node(10));
            ll.Add(9);
            ll.Add(9);
            ll.Add(10);
            Console.WriteLine();
            Console.WriteLine("First linked list to check for palindrome");
            ll.Print();
            bool result = CheckPalindrome(ll);
            Console.Write("Palindrome: ");
            Console.WriteLine(result.ToString());
            Console.WriteLine();
            Console.WriteLine("Second linked list to check for palindrome");
            llToReverse.Print();
            result = CheckPalindrome(llToReverse);
            Console.Write("Palindrome: ");
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
