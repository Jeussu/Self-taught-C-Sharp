using System;
using System.Collections;

namespace GenericAndCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*//Demo SortedList
            1. Declaration and Add
            2. Access by key
            3. Access by index
            4. Check existing key
            5. Clear
             */
            SortedList sl = new SortedList();
            sl.Add(5, "Five");
            sl.Add(4, "Four");
            sl.Add(7, "Seven");
            sl.Add(8, "Eight");

            var keys = sl.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine("Key is {0}, value is {1}", key, sl[key]);
            }

            Console.WriteLine("-----------------");

            //Getby index
            for (int i = 0; i < sl.Count; i++)
            {
                Console.WriteLine("Key is {0}, value is {1}", sl.GetKey(i), sl.GetByIndex(i));
            }

            Console.WriteLine("6 is exists? " + sl.ContainsKey(6));
            sl.Clear();
            Console.WriteLine("After clearing" + sl.Count);
            Console.ReadLine();
        }
    }
}
