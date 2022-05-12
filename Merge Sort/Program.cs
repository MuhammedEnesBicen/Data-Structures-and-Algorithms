using System;

namespace Merge_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = new int[] { 16, 21, 11, 8, 12, 22 };
            var result = sort(array);
            printArray(result);

        }
        
        static int[] sort(int[] whole)
        {
            if (whole.Length == 1) return whole;
            int[] left = new int[whole.Length / 2];
            int[] right = new int[whole.Length - left.Length];


            Array.Copy(whole, 0, left, 0, left.Length);
            Array.Copy(whole, left.Length, right, 0, right.Length);

            left = sort(left);
            right = sort(right);

            merge(left, right, whole);
            return whole;
        }

        static void merge(int[] left, int[] right, int[] whole)
        {
            int leftIndex = 0, rightIndex = 0, wholeIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex]) { whole[wholeIndex] = left[leftIndex]; leftIndex++; }
                else { whole[wholeIndex] = right[rightIndex]; rightIndex++; }
                wholeIndex++;
            }


            int[] rest; int restIndex;
            if (leftIndex >= left.Length) { rest = right; restIndex = rightIndex; }
            else { rest = left; restIndex = leftIndex; }

            for (int i = restIndex; i < rest.Length; i++)
            {
                whole[wholeIndex] = rest[i];
                wholeIndex++;
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