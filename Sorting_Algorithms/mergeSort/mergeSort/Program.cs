using System;
namespace mergeSort
{
  public class Program
  {
    public static int[] MergeSort(int[] inpArr)
    {
      if (inpArr.Length == 1)
        return inpArr;
      int midPoint = inpArr.Length / 2;
      int[] leftArr = new int[midPoint];
      int[] rightArr = new int[inpArr.Length - midPoint];
      Array.Copy(inpArr, 0, leftArr, 0, midPoint);
      Array.Copy(inpArr, midPoint, rightArr, 0, inpArr.Length - midPoint);
      leftArr = MergeSort(leftArr);
      rightArr = MergeSort(rightArr);
      return Merge(leftArr, rightArr);
    }
    public static int[] Merge(int[] leftArr, int[] rightArr)
    {
      int leftPointer = 0;
      int rightPointer = 0;
      int resultPointer = 0;
      int[] resultArr = new int[leftArr.Length + rightArr.Length];
      while (leftPointer < leftArr.Length && rightPointer < rightArr.Length)
      {
        if (leftArr[leftPointer] <= rightArr[rightPointer])
        {
          resultArr[resultPointer] = leftArr[leftPointer];
          resultPointer += 1;
          leftPointer += 1;
        }
        else
        {
          resultArr[resultPointer] = rightArr[rightPointer];
          resultPointer += 1;
          rightPointer += 1;
        }
      }
      if (leftPointer < leftArr.Length)
      {
        Array.Copy(leftArr, leftPointer, resultArr, resultPointer, leftArr.Length - leftPointer);
      }
      if (rightPointer < rightArr.Length)
      {
        Array.Copy(rightArr, rightPointer, resultArr, resultPointer, rightArr.Length - rightPointer);
      }
      return resultArr;
    }
    public static void Main()
    {
      int[] inpArr = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
      Console.WriteLine("Initial array:");
      Array.ForEach(inpArr, elm => Console.Write($"{elm}, "));
      inpArr = MergeSort(inpArr);
      Console.WriteLine();
      Console.WriteLine("Sorted array:");
      Array.ForEach(inpArr, elm => Console.Write($"{elm}, "));
      Console.WriteLine();
      Console.ReadLine();
    }
  }
}