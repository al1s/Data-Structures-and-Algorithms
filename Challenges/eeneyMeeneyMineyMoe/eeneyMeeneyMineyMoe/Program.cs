using System;
using System.Linq;
using LinkedList.Classes;

namespace eeneyMeeneyMineyMoe
{
    public class Program
    {
        /// <summary>
        /// Implementation of Eeney Meeney Miney Moe
        /// </summary>
        /// <param name="inputList">List of parties to play</param>
        /// <param name="number">Which number goes out</param>
        /// <returns>The surviour</returns>
        public static string EeneyMeeneyMineyMoe(LList inputList, int number)
        {
            if (number == 0) return string.Empty;
            Node _curr = inputList.Head;
            Node _prev = inputList.Head;
            int i = 1;
            // there must be only one to stop iterating 
            while(_curr != _curr.Next)
            {
                if(i == number)
                {
                    // current goes out
                    _prev.Next = _curr.Next;
                    _curr = _curr.Next;
                    i = 1;
                }
                else
                {
                    _prev = _curr;
                    _curr = _curr.Next;
                    i += 1;
                }
            }
            return (string)_curr.Value;
        }
        static void Main(string[] args)
        {
            LList llist = new LList();
            llist.Append("Eeney");
            llist.Append("Meeney");
            llist.Append("Miney");
            llist.Append("Moe");
            Console.WriteLine("Initial list:");
            llist.Print();
            string result = EeneyMeeneyMineyMoe(llist, 3);
            Console.WriteLine($"The winner is {result}");
            LList llist1 = new LList();
            string[] array = Enumerable.Range(0, 40000).Select(i => "Num" + i).ToArray();
            foreach (string item in array)
            {
                llist1.Append(item);
            }
            llist1.Print();
            string result1 = EeneyMeeneyMineyMoe(llist1, 30000);
            Console.WriteLine($"The winner is {result1}");
            Console.ReadLine();
        }
    }
}
