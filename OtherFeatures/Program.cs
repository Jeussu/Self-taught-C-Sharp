using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace OtherFeatures
{
    //Demo Labda expression

    internal class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            //Write a lamda expression
            // Using lamda with LINQ
            Func<Student, bool> isTenenage = s => s.Age > 12 && s.Age < 20;

            Student mike = new Student() { Name = "Mike", Age = 18 };
            Console.WriteLine(isTenenage(mike));

            IList<Student> students = new List<Student>()
            {
                new Student() { Name = "Mike", Age = 18 },
                new Student() { Name = "Huong", Age = 20 },
                new Student() { Name = "Lan", Age = 16 },
                new Student() { Name = "Vy", Age = 21 },
            };
            //use linq to query get student is tenenage
            var teenagers = students.Where(isTenenage).ToList();

            foreach (var teen in teenagers)
            {
                Console.WriteLine("Name {0} and age {1}", teen.Name, teen.Age);
            }
            Console.ReadKey();
        }

    }
}
