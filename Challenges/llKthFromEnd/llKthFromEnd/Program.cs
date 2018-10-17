using System;
using LinkedList.Classes;

namespace llKthFromEnd
{

    public class Program
    {
        /// <summary>
        /// Get the value of a linked list member at a given position starting from the end
        /// </summary>
        /// <param name="ll">Linked list to be searched for an element</param>
        /// <param name="position">Position from the end of returning element</param>
        /// <returns>Value of k-th member of LL from the end, Exception when out of range</returns>
        public static int GetKthFromEnd(LList ll, int position)
        {
            int cnt = default(int);
            Node Current = ll.Head;
            while(Current.Next != null)
            {
                cnt += 1;
                Current = Current.Next;
            }
            if (cnt - position < 0) throw new IndexOutOfRangeException();
            Current = ll.Head;
            while(cnt - position > 0)
            {
                cnt -= 1;
                Current = Current.Next;
            }
            return (int) Current.Value;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
