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
                int j = i - 1;

                while (j >= 0 && temp < inpArr[i])
                {
                    inpArr[j + 1] = inpArr[j];
                    j--;
                }
                inpArr[j + 1] = temp;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
