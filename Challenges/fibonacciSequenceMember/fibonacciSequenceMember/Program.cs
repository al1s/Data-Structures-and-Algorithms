using System;

namespace fibonacciSequenceMember
{
    public class Program
    {
        /// <summary>
        /// Given the number get the appropriate of Fibonacci sequence using recursive approach 
        /// </summary>
        /// <param name="sequenceMemberPosition">number of the member</param>
        /// <returns>member of fibonacci sequence</returns>
        public static int FibonacciRecursive(int sequenceMemberPosition)
        {
            if (sequenceMemberPosition == 0) return 0;
            if (sequenceMemberPosition == 1) return 1;
            return FibonacciRecursive(sequenceMemberPosition - 1) + FibonacciRecursive(sequenceMemberPosition - 2);
        }
        /// <summary>
        /// Given the number get the appropriate of Fibonacci sequence using iterative approach 
        /// </summary>
        /// <param name="sequenceMemberPosition">number of the member</param>
        /// <returns>member of fibonacci sequence</returns>
        public static int FibonacciIterative(int sequenceMemberPosition)
        {
            int n1 = 0;
            int n2 = 1;
            int current = default(int);
            for (int i = 0; i < sequenceMemberPosition - 1; i++)
            {
                current = n1 + n2;
                n1 = n2;
                n2 = current;
            }
            return current;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
