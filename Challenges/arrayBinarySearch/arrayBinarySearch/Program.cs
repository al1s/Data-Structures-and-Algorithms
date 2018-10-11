using System;

namespace arrayBinarySearch
{
    public class Program
    {
        public static int BinarySearch(int[] array, int number)
        {
            if (array.Length == 0) return -1;
            int lowBound = 0;
            int highBound = array.Length - 1;
            int midOfArray = (highBound - lowBound) / 2;
            do
            {
                if (array[midOfArray] == number) return midOfArray;
                if (array[midOfArray] > number) highBound = midOfArray;
                else lowBound = midOfArray + 1;
                midOfArray = (highBound - lowBound) / 2 + lowBound;

            } while (lowBound <= highBound);
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // BinarySearch(new int[] { 1, 2, 3, 4, 5 }, 4);
            // BinarySearch(new int[] { 1, 2, 4, 5 }, 99);
            // BinarySearch(new int[] { 1, 2, 4, 5 }, 1);
            BinarySearch(new int[] { 1, 2 }, 2);
        }
    }
}
