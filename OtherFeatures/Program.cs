using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace OtherFeatures
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    //Demo Labda expression

    internal class Program
    {


        static void Main(string[] args)
        {
            var result = DoSomething("", "", 0);
            Console.WriteLine(result.Item1);
            Console.WriteLine(result.Item2);
            Console.WriteLine(result.Item3);
            Console.ReadKey();
        }

        public static Tuple<string, string, int>DoSomething(String firstName, String lastName, int age)
        {
            firstName = "A";
            lastName = "B";
            age = 100;
            return Tuple.Create(firstName, lastName, age);
            //return new Customer(firstName, lastName, age);
        }

    }
}
