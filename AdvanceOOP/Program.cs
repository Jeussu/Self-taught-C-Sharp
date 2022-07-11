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

    //Demo Static 

    // Allow user enter Celsius / Fahrenheit, then convert to Fahrenheit / Celsius
    // F = C * 9 / 5 + 32
    // C = (F - 32) * 5 / 9

    public static class TemperatureConverter
    {
        public static double ConvertFromCToF(string Ctemp)
        {
            double celsius = Double.Parse(Ctemp);
            return celsius * 9 / 5 + 32;
        }

        public static double ConvertFromFToC(string Ftemp)
        {
            double fahrenheit = Double.Parse(Ftemp);
            return (fahrenheit - 32) * 5 / 9;
        }
    }
    //public class Person
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public int Age { get; set; }

    //    public Person(string firstName, string lastName)
    //    {// Constructor 1
    //        FirstName = firstName;
    //        LastName = lastName;
    //    }

    //    public Person(string firstName, string lastName, int age) : this(firstName, lastName) //calling
    //    {
    //        Age = age;
    //    }
    //}

    public class Program
    {
        static void Main(string[] args)
        {
            //AddingWrapper aw = new AddingWrapper();
            //Console.WriteLine(aw.add (1, 2));
            //Console.WriteLine(aw.add(1, 2, 3, 4));

            //Person person1 = new Person("Tien Dung", "Bui");
            //Person person2 = new Person("Quang Hai", "Nguyen", 21);
            //Console.WriteLine("Person1: " + person1);
            //Console.WriteLine("Person2: " + person2);

            Console.WriteLine("Please select the convertor direction");
            Console.WriteLine("1. From Celsius to Fahrenheit.");
            Console.WriteLine("2. From Fahrenheit to Celsius");
            Console.Write(":");

            string selection = Console.ReadLine();
            double F, C = 0;

            switch (selection)
            {
                case "1":
                    Console.Write("Please enter the Celsius temperature: ");
                    F = TemperatureConverter.ConvertFromCToF(Console.ReadLine());   
                    Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                    break;

                    case "2":
                    Console.WriteLine("Please enter the Fahrenheit temperature: ");
                    C = TemperatureConverter.ConvertFromFToC(Console.ReadLine());
                    Console.WriteLine("Temperature in Celsius: {0:F2}", C);
                    break;

                    default:
                    Console.WriteLine("Please select a convertor.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
