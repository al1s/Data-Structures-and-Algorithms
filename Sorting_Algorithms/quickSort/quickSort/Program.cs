using System;

namespace quickSort
{
    public class Program
    {
        /// <summary>
        /// Quick sort using Hoare partition scheme with a pivot as a middle 
        /// </summary>
        /// <param name="inpArr">An array to be sorted</param>
        /// <param name="left">Starting position for the sort</param>
        /// <param name="right">Ending position for the sort</param>
        public static void QuickSort(int[] inpArr, int left, int right)
        {
            if (left < right)
            {
                int partition = Partition(inpArr, left, right);
                QuickSort(inpArr, left, partition);
                QuickSort(inpArr, partition + 1, right);
            }
        } 
        public static int Partition(int[] inpArr, int left, int right)
        {
            // define pivot as a middle of the array
            int pivot = inpArr[(left + right) / 2];
            while (true)
            {
                int lo = left - 1;
                int hi = right + 1;
                // go from left up to the right till we'll find element greater than pivot
                do
                {
                    lo += 1;
                } while (inpArr[lo] < pivot);
                // go from right down to the left till we'll find element greater than pivot
                do
                {
                    hi -= 1;
                } while (inpArr[hi] > pivot);
                // if our lower index greater or lower than our higher index we should partition
                // the array by the index with the lowest element value 
                if (lo >= hi)
                {
                    return hi;
                }
                // we've found two elements which are not where they should be:
                // element to the left of the pivot is greater than pivot and
                // element to the right of the pivot is lower than pivot, so
                // swap them (using tuple syntax)
                (inpArr[lo], inpArr[hi]) = (inpArr[hi], inpArr[lo]);
            }
        }

        private static void Main(string[] args)
        {
            int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            //int[] arr = { 10, 80, 30, 90, 40, 50, 70 };
            Console.WriteLine("Initial array:");
            Array.ForEach(arr, elm => Console.Write($"{elm}, "));
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine();
            Console.WriteLine("Sorted array:");
            Array.ForEach(arr, elm => Console.Write($"{elm}, "));
            Console.ReadLine();
        }
    }
}
