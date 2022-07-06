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

            //if (6 <= age && age < 11)
            //{
            //    Console.WriteLine("Elementary");
            //}
            //else if (11 <= age && age < 15)
            //{
            //    Console.WriteLine("Middle School");
            //}
            //else if (15 <= age && age < 18)
            //{
            //    Console.WriteLine("High School");
            //}
            //else
            //{
            //    Console.WriteLine("Out of Range");
            //}
            switch (age)
            {
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Elementary");
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                    Console.WriteLine("Middle School");
                    break;
                case 15:
                case 16:
                case 17:
                    Console.WriteLine("High School");
                    break;
                default:
                    Console.WriteLine("Out of Range");
                    break;
            }
            Console.ReadLine();
        }
    }
}
