using System;
using System.Diagnostics;
using System.Linq;

namespace Quicksort_Complete
{
    internal class Program
    {
        static public int Partition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        static public void Quicksort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    Quicksort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quicksort(arr, pivot + 1, right);
                }
            }
        }
        static void Main(string[] args)
        {
            int length = 1000; //Enter length of randomised list
            int[] arr = new int[length];
            for (int i = 0; i <= length - 1; i++)
            {
                arr[i] = i + 1;
            }
            Random random = new Random();
            arr = arr.OrderBy(x => random.Next()).ToArray();

            Console.WriteLine("Unsorted");
            foreach (int e in arr)
            {
                Console.WriteLine(e);
            }

            Stopwatch stopwatch = new();

            stopwatch.Start();
            Partition(arr, 0, length - 1);
            Quicksort(arr, 0, length - 1);
            stopwatch.Stop();

            Console.WriteLine("Sorted");

            foreach (int e in arr)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Elements: " + length);
            Console.WriteLine(" Elapsed Time for Quicksort: {0} ms", stopwatch.Elapsed.Milliseconds);
        }
    }
}
