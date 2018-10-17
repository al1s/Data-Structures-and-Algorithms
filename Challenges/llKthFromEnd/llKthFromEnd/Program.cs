using System;
using LinkedList.Classes;

namespace llKthFromEnd
{

    class Program
    {
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
