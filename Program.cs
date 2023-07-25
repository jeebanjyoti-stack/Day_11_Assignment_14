using System;
using System.Diagnostics;


namespace Day_11_Assignment_14
{
    internal class Program
    {
        //Bubble Sort
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - 1 - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }



                }
                if (!swapped)
                {
                    break;
                }
            }
        }



        //Insertion Sort
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "");
            }
            Console.WriteLine("\n");
        }




        static void Main(string[] args)
        {
            int[] arr = { 7, 4, 5, 2, 8, 22, };
            Console.WriteLine("Print Array without Sort");
            Print(arr);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            InsertionSort(arr);
            stopwatch.Stop();
            Console.WriteLine("After Insertion Sort");
            Print(arr);
            Console.WriteLine($"ArraySize {arr.Length} Time Taken in InsetionSort {stopwatch.Elapsed.TotalMilliseconds} milliseconds");



            int[] arr2 = { 7, 4, 5, 2, 8, 22, 12, 53 };
            Console.WriteLine("Print Array without Sort");
            Print(arr2);
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch.Start();
            BubbleSort(arr2);
            stopwatch.Stop();
            Console.WriteLine("After Bubble Sort");
            Print(arr2);
            Console.WriteLine($"ArraySize {arr.Length} Time Taken in BubbleSort {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
            Console.ReadKey();
        }
    }
}
