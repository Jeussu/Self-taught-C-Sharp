using System;
using System.Collections;

namespace GenericAndCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*//Demo Hashtable
            1. Declaration
            2. Add
            3. Remove
            4. Check existing key/value
            5. Get ICollection of keys / value
            6. Clear
             */ 
           
            Hashtable ht = new Hashtable();
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");

            ht.Remove(1);
            Console.WriteLine("1 exists? " + ht.ContainsKey(1));

            var keys = ht.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine("Key is {0} and value is {1}", key, ht[key]);
            }

            ht.Clear();
            Console.WriteLine("After clear {0}", ht.Count);
    
            Console.ReadLine();
        }
    }
}
