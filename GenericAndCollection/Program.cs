using System;
using System.Collections;

namespace GenericAndCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add, AddRange, insert, remove, retrieve an item, using foreach
            ArrayList t = new ArrayList();
            t.Add(1);
            t.Add("Hello");
            t.Add(1.0m);

            ArrayList t2 = new ArrayList();
            t2.Add(10);
            t2.AddRange(t);

            //foreach (var item in t2)
            //{
            //    Console.WriteLine(item);
            //}

            t2.Insert(1, "new value");
            t2.Add("new value");
            t2.Remove("new value");
            int firstItem = (int) t2[0];
            foreach (var item in t2)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
