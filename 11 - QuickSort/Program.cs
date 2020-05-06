using System;

namespace _11___QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 2, 6, 4, 3, 5, 1 };
            //int[] arr = { 2, 1, 4, 3 };
            Console.WriteLine("Original array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            QuickSortPractice(arr, 0, arr.Length - 1);
            Console.WriteLine("After QuickSort:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public static void QuickSortPractice(int[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            int pivot = left + (right - left) / 2;
            int index = PartionPractice(arr, left, right, pivot);
            QuickSortPractice(arr, left, index - 1);
            QuickSortPractice(arr, index, right);
        }

        public static int PartionPractice(int[] arr, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (arr[left] < arr[pivot])
                {
                    left++;
                }
                while (arr[right] > arr[pivot])
                {
                    right--;
                }
                if (left <= right)
                {
                    Swap(arr, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }

        public static void Swap(int[] arr, int a, int b)
        {
            var temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
