using System;
using System.Collections.Generic;
using System.Text;

namespace _13___Recursion
{
    public class AnagramApp
    {
        static int size;
        static int count;
        static char[] arrChar = new char[100];
        public AnagramApp()
        {
            size = 3;
            count = 0;
            string cat = "cat";
            arrChar = cat.ToCharArray();
            Anagram(3);
        }
        public static void Anagram(int newSize)
        {
            if (newSize == 1)
            {
                return;
            }
            for (int i = 0; i < newSize; i++)
            {
                Anagram(newSize - 1);
                if (newSize == 2)
                {
                    DisplayWord();
                }
                Rotate(newSize);
            }
        }

        public static void Rotate(int newSize)
        {
            int j;
            int position = size - newSize;
            char temp = arrChar[position];
            for (j = position + 1; j < size; j++)
            {
                arrChar[j - 1] = arrChar[j];
            }
            arrChar[j - 1] = temp;
        }

        public static void DisplayWord()
        {
            for (int i = 0; i < arrChar.Length; i++)
            {
                Console.Write(arrChar[i]);
            }
        }
    }
}
