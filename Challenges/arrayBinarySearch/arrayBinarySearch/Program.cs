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
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int number = 4;
            Console.WriteLine($"Index for number {number} in ({String.Join(", ", array)}): {BinarySearch(array, number)}");
            array =new int[] { 1, 2, 4, 5 };
            number = 99;
            Console.WriteLine($"Index for number {number} in ({String.Join(", ", array)}): {BinarySearch(array, number)}");
            array = new int[] { 1, 2, 4, 5 };
            number = 1;
            Console.WriteLine($"Index for number {number} in ({String.Join(", ", array)}): {BinarySearch(array, number)}");
            array = new int[] { 1, 2 };
            number = 2;
            Console.WriteLine($"Index for number {number} in ({String.Join(", ", array)}): {BinarySearch(array, number)}");
            Console.ReadLine();
        }
    }
}
