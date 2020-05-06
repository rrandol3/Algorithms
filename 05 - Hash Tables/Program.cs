using System;
using System.Collections;
using System.Collections.Generic;

namespace _05___Hash_Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            //strongly typed hash table 
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary[0] = "Randolph";
            dictionary.Add(1, "Krista");
            var reggie = dictionary[0];
            var krista = dictionary[1];
            Console.WriteLine("Get key 0:" + reggie);
            Console.WriteLine("Get key 1:" + krista);
            var test = dictionary.Remove(0, out string test1);
            Console.WriteLine("Get key 0 is now:" + test);

            //Non strongly type dictionary
            Hashtable hashtable = new Hashtable();
            hashtable.Add(9, "Randolph");
            Console.WriteLine("Hashtable at 0:" + hashtable[0]);

            //Stores unique values without a key, non-unique items will be skipped
            HashSet<string> hashset = new HashSet<string>();
            hashset.Add("Reggie");
            hashset.Add("Reggie");
        }
    }
}
