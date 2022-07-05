using System;

namespace BasicFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Enter an age,
             * in case, 6 <= age and age < 11, display: Element
             * 11<= age and age < 15, display: Middle School
             * 15<= age and age < 18, display: High School
             * otherwise, display: Out of range
             */

            Console.WriteLine("Enter an age: ");
            int age = Int32.Parse(Console.ReadLine());

            if (6 <= age && age < 11)
            {
                Console.WriteLine("Elementary");
            }
            else if (11 <= age && age < 15)
            {
                Console.WriteLine("Middle School");
            }
            else if (15 <= age && age < 18)
            {
                Console.WriteLine("High School");
            }
            else
            {
                Console.WriteLine("Out of Range");
            }
        }
    }
}
