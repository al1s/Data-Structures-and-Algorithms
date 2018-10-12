using System;

namespace arrayBinarySearch
{
    public class Program
    {
        /// <summary>
        /// Search for a number in a sorted array
        /// </summary>
        /// <param name="array">Sorted array</param>
        /// <param name="number">A number to find in an array</param>
        /// <returns>Zero-based position of a number in an array. -1 if not found.</returns>
        public static int BinarySearch(int[] array, int number)
        {
            if (array.Length == 0) return -1;
            int lowBound = 0;
            int highBound = array.Length - 1;
            do
            {
                int midOfArray = (highBound + lowBound) / 2 ;
                if (array[midOfArray] == number) return midOfArray;
                if (array[midOfArray] > number) highBound = midOfArray;
                else lowBound = midOfArray + 1;

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
