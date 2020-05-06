using System;
using System.Collections.Generic;

namespace _14___Dynamic_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(4));
        }

        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
    }

    public class DPFactorial
    {
        Dictionary<int, int> dictionary;
        public DPFactorial()
        {
            dictionary = new Dictionary<int, int>();
        }
        public int Factorial(int n)
        {
            if (n <= 2)
            {
                return n;
            }
            else
            {
                if (dictionary.ContainsKey(n))
                {
                    return dictionary[n];
                }
                else
                {
                    dictionary.Add(n, n);
                    return n * Factorial(n - 1);
                }
            }
        }
    }
}
