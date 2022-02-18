using System;
using System.Diagnostics;
using System.Linq;

namespace Insertionsort_Complete
{
    public class Program
    {
        static public void Insertionsort(int[] arr)
        {
            int key, j;

            for (int i = 0; i < arr.Length; i++)
            {
                key = arr[i];
                j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
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
            Insertionsort(arr);
            stopwatch.Stop();

            Console.WriteLine("Sorted");

            foreach (int e in arr)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Elements: " + length);
            Console.WriteLine(" Elapsed Time for Insertionsort: {0} ms", stopwatch.ElapsedMilliseconds);
        }
    }
}
