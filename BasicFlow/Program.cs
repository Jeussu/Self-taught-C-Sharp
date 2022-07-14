using System;
using System.Collections.Generic;

namespace BasicFlow
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Address> Addresses { get; set; }
        public Person Spouse { get; set; }
    }

    public class Address
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }    
        public string State { get; set; }
        public string Zip { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Person p = null;
            if (p != null)
            {
                Console.WriteLine(p.Age);
            }
            Console.WriteLine(p?.Age);
            if (p!= null && p.Spouse != null)
            {
                Console.WriteLine(p.Spouse.FirstName);
            }

            Console.WriteLine(p?.Spouse?.FirstName);
            Console.WriteLine(p?.Addresses?[0].City);
            Console.WriteLine("Done");

            Console.ReadLine();
        }
    }
}
