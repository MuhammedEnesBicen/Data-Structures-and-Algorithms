using System;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, there!");
            var array = new int[] { 22, 27, 16, 2, 18, 6 };
            insertionSort(array);
            printArray(array);


        }
        
       static void insertionSort(int[] array)
        {
            int n = array.Length;

            int i, j, key;

            for (i = 1; i < n; i++)
            {
                j = i - 1;
                key = array[i];

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    array[j] = key;
                    j--;
                }
            }
        }


        static void printArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}