using System;

namespace _10___Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(BinarySearch(arr, 6));
            //Console.WriteLine(BinarySearchRecursive(arr, 4, 0, arr.Length - 1));
        }

        public static int BinarySearchIterative(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return -1;
        }

        public static int BinarySearch(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (target == arr[mid])
                {
                    return mid;
                }
                else if (target < arr[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;// not match found
        }
    }
}
