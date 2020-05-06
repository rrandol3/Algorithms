using System;

namespace _12___Merge_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 2, 3, 7, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            MergeSortPractice(arr, new int[arr.Length],  0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public static void MergeSortPractice(int[] arr, int[] aux, int low, int high)
        {
            if (low >= high)
            {
                return;
            }
            int mid = low + (high - low) / 2;
            MergeSortPractice(arr, aux, low, mid);
            MergeSortPractice(arr, aux, mid + 1, high);
            MergePractice1(arr, aux, low, mid, high);
        }
        public static void MergePractice1(int[] arr, int[] aux, int low, int mid, int high)
        {
            int i = low;
            int j = mid + 1;

            Array.Copy(arr, low, aux, low, high - low + 1);

            for (int k = low; k <+ high; k++)
            {
                if (i > mid)
                {
                    arr[k] = aux[j];
                    j++;
                }
                else if (j > high)
                {
                    arr[k] = aux[i];
                    i++;
                }
                else if (aux[j] < aux[i])
                {
                    arr[k] = aux[j];
                    j++;
                }
                else
                {
                    arr[k] = aux[i];
                    i++;
                }
            }
        }
        public static int[] MergePractice(int[] arr1, int[] arr2)
        {
            int i = 0;//arr1
            int j = 0;//arr2
            int k = 0;//arr3
            //[ 1, 3, 5 ]  [ 2, 4, 6 ]
            int[] arr3 = new int[arr1.Length + arr2.Length];

            while (i < arr1.Length && j < arr2.Length)//neither arr1 or arr2 is empty;
            {
                if (arr1[i] < arr2[j])
                {
                    arr3[k] = arr1[i];
                    i++;
                    k++;
                }
                else
                {
                    arr3[k] = arr2[j];
                    j++;
                    k++;
                }
            }

            while (i < arr1.Length)//arr1 is not empty but arr2 is
            {
                arr3[k] = arr1[i];
                i++;
                k++;
            }

            while (j < arr2.Length)////arr2 is not empty but arr1 is
            {
                arr3[k] = arr2[j];
                j++;
                k++;
            }

            return arr3;
        }
    }
}
