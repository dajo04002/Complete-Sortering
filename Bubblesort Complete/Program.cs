using System;
using System.Diagnostics;
using System.Linq;

namespace Bubblesort_Complete
{
    public class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static public void Bubblesort(int[] arr)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(ref arr[i], ref arr[i + 1]);
                    }
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
            foreach(int e in arr)
            {
                Console.WriteLine(e);
            }

            Stopwatch stopwatch = new();

            stopwatch.Start();
            Bubblesort(arr);
            stopwatch.Stop();

            Console.WriteLine("Sorted");

            foreach (int e in arr)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Elements: " + length);
            Console.WriteLine(" Elapsed Time for Bubblesort: {0} ms", stopwatch.Elapsed.Milliseconds);


        }
    }
}
