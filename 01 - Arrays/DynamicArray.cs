using _00___ADTs;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01___Arrays
{
    public class DynamicArray<T> : _00___ADTs.IList<T>
    {
        private T[] arr;
        int count;
        public DynamicArray()
        {
            arr = new T[2];
            count = 0;
        }
        public void Add(T value)
        {
            if (count == arr.Length)
            {
                DoubleCapacity();
            }
            arr[count] = value;
            count++;
        }

        public T Get(int index)
        {
            return arr[index];
        }

        public void Remove(int index)
        {
            ArrayShift(index);
            count--;
        }

        public int Size()
        {
            return arr.Length;
        }

        public int Count()
        {
            return count;
        }

        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        private void DoubleCapacity()
        {
            T[] temp = new T[arr.Length * 2];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
        }

        private void ArrayShift(int indexToRemove)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == indexToRemove)
                {
                    while (i < arr.Length - 1)
                    {
                        arr[i] = arr[i + 1];
                        i++;
                    }
                }
            }
        }
    }
}
