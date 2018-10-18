using System;
using LinkedList.Classes;

namespace MergeLL
{
    public class Program
    {
        /// <summary>
        /// Merge (zip) two linked lists
        /// </summary>
        /// <param name="firstLL">First linked list to be merged</param>
        /// <param name="secobdLL">Second linked list to be merged</param>
        /// <returns>Merged linked list (constructed on the base of the first one)</returns>
        public static LList MergeLL(LList firstLL, LList secondLL)
        {
            Node curr1 = firstLL.Head;
            Node curr2 = secondLL.Head;
            Node runner1 = curr1; 
            Node runner2 = curr2;
            while (curr1 != null && curr2 != null)
            {
                if(curr1.Next == null)
                {
                    curr1.Next = curr2;
                    break;
                }
                runner1 = curr1.Next;
                runner2 = curr2.Next;
                curr2.Next = runner1;
                curr1.Next = curr2;
                curr1 = runner1;
                curr2 = runner2;
            }
            secondLL = null;
            return firstLL;
        }
        static void Main(string[] args)
        {
            LList ll1 = new LList(new Node(10));
            LList ll2 = new LList(new Node("Ten"));
            ll1.Add(9);
            ll1.Add(8);
            ll2.Add("Nine");
            ll2.Add("Eight");
            Console.WriteLine();
            Console.WriteLine("First linked list:");
            ll1.Print();
            Console.WriteLine();
            Console.WriteLine("Second linked list:");
            ll2.Print();
            Console.WriteLine();
            Console.WriteLine("Resulting linked list:");
            LList result = MergeLL(ll1, ll2);
            result.Print();
            Console.ReadLine();
        }
    }
}
