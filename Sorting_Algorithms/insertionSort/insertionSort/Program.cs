using System;

namespace insertionSort
{
    
    class Program
    {
        static void InsertionSort(int[] inpArr)
        {
            for (int i = 1; i < inpArr.Length; i++)
            {
                int temp = inpArr[i];
                int j = 0;
                for (j = i - 1; j >= 0; j--)
                {
                    if (inpArr[j] > temp)
                        inpArr[j + 1] = inpArr[j];
                    else
                        break;
                }
                inpArr[j + 1] = temp;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Console.WriteLine("Initial array:");
            Array.ForEach(arr, elm => Console.Write($"{elm}, "));
            InsertionSort(arr);
            Console.WriteLine();
            Console.WriteLine("Sorted array:");
            Array.ForEach(arr, elm => Console.Write($"{elm}, "));
            Console.ReadLine();
        }
    }
}
