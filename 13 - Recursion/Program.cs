using System;

namespace _13___Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(BinarySearch(arr, 0, arr.Length - 1, 5));
            var str = "testing";
            var result = ReverseStringRec(str.ToCharArray(), 0, str.Length - 1);
            Console.WriteLine(str);
            Console.WriteLine(result);
        }

        //current number is the sum of the previous 2
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
   
        public static void PrintNumbers(int n)
        {
            if (n == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine(n);
                PrintNumbers(n - 1);
            }
        }

        public static int Triangle(int n)
        {
            Console.WriteLine("Entering:n = " + n);
            if (n == 1)
            {
                Console.WriteLine("Returning 1");
                return 1;
            }
            else
            {
                int temp = n + Triangle(n - 1);
                Console.WriteLine("Returning:" + temp);
                return temp;
            }
        }

        public static int Factorial(int n)
        {
            Console.WriteLine("Entering:n = " + n);
            if (n <= 2)
            {
                Console.WriteLine("Returning " + n);
                return n;
            }
            else
            {
                int temp = n * Factorial(n - 1);
                Console.WriteLine("Returning:" + temp);
                return temp;
            }
        }

        public static void Towers(int topN, char from, char inter, char to)
        {
            if (topN == 1)
            {
                Console.WriteLine("Disk 1 from " + from + " to " + to);
            }
            else
            {
                Towers(topN - 1, from, to, inter);
                Console.WriteLine("Disk " + topN + " from " + from + " to " + to);
                Towers(topN - 1, inter, from, to);
            }
        }

        //[1, 2, 3, 4, 5]
        public static int BinarySearch(int[] arr, int low, int high, int target)
        {
            if (low >= high)
            {
                return -1;
            }
            int mid = low + (high - low) / 2;
            if (arr[mid] == target)
            {
                return mid;
            }
            else if (target < arr[mid])
            {
                high = mid - 1;
                return BinarySearch(arr, low, high, target);
            }
            else
            {
                low = mid + 1;
                return BinarySearch(arr, low, high, target);
            }
        }

        public static string ReverseString(string str)
        {
            int low = 0;
            int high = str.Length - 1;
            char[] charArr = str.ToCharArray();
            while (low <= high)
            {
                var temp = charArr[low];
                charArr[low] = charArr[high];
                charArr[high] = temp;
                low++;
                high--;
            }

            return new string(charArr);
        }

        public static char[] ReverseStringRec(char[] charArr, int low, int high)
        {
            if (low >= high)
            {
                return charArr;
            }
            else
            {
                var temp = charArr[low];
                charArr[low] = charArr[high];
                charArr[high] = temp;
                return ReverseStringRec(charArr, low + 1, high -1);
            }
        }
    }
}
