using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericAndCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*//Demo Dictionary
            1. Declaration
            2. Add
            3. Remove
            4. Foreach to access.
             */ 
           IDictionary<int, string> demo = new Dictionary<int, string>();
            demo.Add(1, "One");
            demo.Add(2, "Two");
            demo.Add(3, "Three");

            demo.Remove(3);
            foreach (var item in demo)
            {
                Console.WriteLine("Key is {0}, value is {1}", item.Key, item.Value);
            }
            
    
            Console.ReadLine();
        }
    }
}
