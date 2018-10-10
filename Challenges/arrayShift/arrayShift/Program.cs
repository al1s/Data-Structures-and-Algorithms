using System;

namespace arrayShift
{
    class Program
    {
        static int[] ArrayShift(int[] array, int number)
        {
            return default(int[]);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArrayShift(new int[] { 2, 4, 6, 7 }, 5);
            ArrayShift(new int[] { 4, 8, 15, 23, 42 }, 16);
        }
    }
}
