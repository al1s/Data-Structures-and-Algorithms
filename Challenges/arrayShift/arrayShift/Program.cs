using System;

namespace arrayShift
{
    class Program
    {
        static int[] ArrayShift(int[] array, int number)
        {
            int arrLength = array.Length;
            int midOfArray = (arrLength / 2) + (arrLength % 2 == 0 ? 0 : 1);
            int[] result = new int[arrLength + 1];
            for (int i = 0; i < result.Length; i++)
            {
                if (i < midOfArray) result[i] = array[i];
                else if (i == midOfArray) result[i] = number;
                else result[i] = array[i - 1];
            }
            return result;
        }

        // Stretch goal
        static int[] ArrayUnShift(int[] array)
        {

            int arrLength = array.Length;
            int[] result = new int[arrLength - 1];
            int midOfArray = (arrLength / 2);
            for (int i = 0; i < arrLength; i++)
            {
                if (i < midOfArray) result[i] = array[i];
                else if(i> midOfArray) result[i - 1] = array[i];
            }
            return result;
        }

        static void Main(string[] args)
        {
            int[] arr1 = ArrayShift(new int[] { 2, 4, 6, 7 }, 5);
            int[] arr2 = ArrayShift(new int[] { 4, 8, 15, 23, 42 }, 16);
            Array.ForEach(arr1, elm => Console.Write($"{elm}, "));
            Console.WriteLine();
            Array.ForEach(arr2, elm => Console.Write($"{elm}, "));
            Console.WriteLine();
            Array.ForEach(ArrayUnShift(arr1), elm => Console.Write($"{elm}, "));
            Console.WriteLine();
            Array.ForEach(ArrayUnShift(arr2), elm => Console.Write($"{elm}, "));
            Console.ReadLine();
        }
    }
}
