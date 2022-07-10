using System;

namespace AdvanceOOP
{
    //public class AddingWrapper
    //{//demo overloading
    //    public int add (int a, int b)
    //    {
    //        return a + b;
    //    }

    //    public int add(int a, int b, int c)
    //    {
    //        return a + b + c;
    //    }

    //    public float add(float a, float b, float c, float d)
    //    {
    //        return a + b + c + d;
    //    }
    //}

    //Demo Constructor overloading 
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    
        public Person (string firstName, string lastName)
        {// Constructor 1
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, int age) : this (firstName, lastName) //calling
        {
            Age = age;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //AddingWrapper aw = new AddingWrapper();
            //Console.WriteLine(aw.add (1, 2));
            //Console.WriteLine(aw.add(1, 2, 3, 4));

            Person person1 = new Person("Tien Dung", "Bui");
            Person person2 = new Person("Quang Hai", "Nguyen", 21);
            Console.WriteLine("Person1: " + person1);
            Console.WriteLine("Person2: " + person2);

            Console.ReadLine();
        }
    }
}
