using System;
using System.Collections.Generic;
using System.Text;

namespace _12___Merge_Sort
{
    public class MergeSortProgram
    {
        int[] arr;
        public int[] AnswerArray { get; set; }
        public MergeSortProgram(int[] array)
        {
            arr = array;
            AnswerArray = new int[arr.Length];
        }
        public void Sort()
        {
            int size = arr.Length;
            int[] tempArray = new int[size];
            //call sort here
            MergeSort(arr, tempArray, 0, size - 1);
        }
        public void MergeSort(int[] arr, int[] tempArray, int lowerBound, int upperBound)
        {
            if (lowerBound == upperBound)
            {
                return;
            }
            else
            {
                int mid = lowerBound + (upperBound - lowerBound) / 2;
                MergeSort(arr, tempArray, lowerBound, mid);
                MergeSort(arr, tempArray, mid + 1, upperBound);
                Merge(arr, tempArray);
            }
        }

        public void Merge(int[] arr1, int[] arr2)
        {
            int arr1Index = 0;
            int arr2Index = 0;
            int arr3Index = 0;
            int[] arr3 = new int[arr1.Length + arr1.Length];
            while (arr1Index < arr1.Length && arr2Index < arr2.Length)//neither array is empty
            {
                if (arr1[arr1Index] < arr2[arr2Index])
                {
                    arr3[arr3Index++] = arr1[arr1Index++];
                }
                else
                {
                    arr3[arr3Index++] = arr2[arr2Index++];
                }
            }
            while (arr1Index < arr1.Length)//arr1 is not empty
            {
                arr3[arr3Index++] = arr1[arr1Index++];
            }
            while (arr2Index < arr2.Length)//arr2 is not empty
            {
                arr3[arr3Index++] = arr2[arr2Index++];
            }
            AnswerArray = arr3;
        }

        public void Display()
        {
            //for (int i = 0; i < answerArray.Length; i++)
            //{
            //    Console.Write(answerArray[i] + " ");
            //}
        }
    }
}
