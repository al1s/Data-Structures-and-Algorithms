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
            result[midOfArray] = number;
            for (int i = 0; i < result.Length; i++)
            {
                if (i < midOfArray) result[i] = array[i];
                else if (i == midOfArray) result[i] = number;
                else result[i] = array[i - 1];
            }
            return result;
        }
        static void Main(string[] args)
        {
            Array.ForEach(ArrayShift(new int[] { 2, 4, 6, 7 }, 5), elm => Console.Write($"{elm}, "));
            Console.WriteLine();
            Array.ForEach(ArrayShift(new int[] { 4, 8, 15, 23, 42 }, 16), elm => Console.Write($"{elm}, "));
            Console.ReadLine();
        }
    }
}
