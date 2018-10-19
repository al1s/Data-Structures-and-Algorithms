using System;
using LinkedList.Classes;

namespace palindromeLinkedList
{
    public class Program
    {
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
            LList ll = new LList(new Node(10));
            ll.Add(9);
            ll.Add(9);
            ll.Add(10);
            LList ll2 = new LList(new Node(10));
            ll2.Add(9);
            ll2.Add(8);
            ll2.Add(10);
            Console.WriteLine();
            Console.WriteLine("First linked list to check for palindrome");
            ll.Print();
            bool result = CheckPalindrome(ll);
            Console.Write("Palindrome: ");
            Console.WriteLine(result.ToString());
            Console.WriteLine();
            Console.WriteLine("Second linked list to check for palindrome");
            ll2.Print();
            result = CheckPalindrome(ll2);
            Console.Write("Palindrome: ");
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
