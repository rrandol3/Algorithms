using System;
using System.Collections.Generic;

namespace _20___Coderust_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(BinarySearch(nums, 1));
            Console.WriteLine(BinarySearchRec(nums, 0, nums.Length -1, 1));
        }

        //Binary Search
        //Given a sorted array of integers, return the index of the given key. Return -1 if the key is not found.
        public static int BinarySearch(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (target > nums[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }
        public static int BinarySearchRec(int[] nums, int low, int high, int target)
        {
            if (low > high)
            {
                return -1;
            }
            int mid = low + (high - low) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (target > nums[mid])
            {
                return BinarySearchRec(nums, mid + 1, high, target);
            }
            else
            {
                return BinarySearchRec(nums, low, mid - 1, target);
            }
        }

        //Find Maximum in Sliding Window
        //Given a large array of integers and a window of size w, find the current maximum value in the window as the window slides through the entire array.
        //Notes: did not get right
        public static List<int> MaxSlidingWindow(int[] arr, int windowSize)
        {
            List<int> maxes = new List<int>();

            return maxes;
        }

        //Search a Rotated Array

    }
}
