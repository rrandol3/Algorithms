using System;
using System.Collections.Generic;

namespace _01___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 6, 8, 10 };
            int[] arr2 = { 1, 3, 5, 7 };
            var ans = MergeSortedArrays(arr, arr2);
            for (int i = 0; i < ans.Length; i++)
            {
                Console.Write(ans[i] + " ");
            }
        }

        //Traveral of array
        public static void ArrayTraversal(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        //Reversed traversal of array
        public static void ArrayTraversalReversed(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }

        //Matrix traversal, square grid
        //declaration: int[,] matrix = new int[3, 3];
        //assignment: matrix[0, 0] = 1;
        public static void MatrixTraversal(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("Row {0} :", i);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }

        //Jagged array (array of arrays) traversal
        //declaration: int[][] arr = new int[3][];
        //assignment: arr[0] = new int[2] { 1, 2 };
        public static void JaggedArrayTraversal(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Array {0} :", i);
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]);
                }
                Console.WriteLine();
            }
        }

        public static string ReverseString(string str)
        {
            var charString = str.ToCharArray();
            int left = 0;
            int right = charString.Length - 1;
            while (left <= right)
            {
                var temp = charString[left];
                charString[left] = charString[right];
                charString[right] = temp;
                left++;
                right--;
            }
            return new string(charString);
        }

        public static void ReverseArray(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                var temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }

        public static int[] MergeSortedArrays(int[] arr1, int[] arr2)
        {
            var ans = new int[arr1.Length + arr2.Length];
            int ansIndex = 0;
            int arr1Index = 0;
            int arr2Index = 0;
            while (arr1Index < arr1.Length && arr2Index < arr2.Length)
            {
                if (arr1[arr1Index] < arr2[arr2Index])
                {
                    ans[ansIndex] = arr1[arr1Index];
                    ansIndex++;
                    arr1Index++;
                }
                else
                {
                    ans[ansIndex] = arr2[arr2Index];
                    ansIndex++;
                    arr2Index++;
                }
            }

            while (arr1Index < arr1.Length)
            {
                ans[ansIndex] = arr1[arr1Index];
                ansIndex++;
                arr1Index++;
            }

            while (arr2Index < arr2.Length)
            {
                ans[ansIndex] = arr2[arr2Index];
                ansIndex++;
                arr2Index++;
            }

            return ans;
        }
    }
}
