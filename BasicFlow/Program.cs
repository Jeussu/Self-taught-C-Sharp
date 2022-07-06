using System;

namespace BasicFlow
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while (i++ < 6)
            //{
            //    Console.WriteLine("Current value is {0}", i);
            //}
            //Console.WriteLine("\n Do While result");
            //i = 1;

            //do
            //{
            //    Console.WriteLine("Current value is {0}", i);
            //} while (i++ < 6);
            /*
             1. Allow user enter any character and only exit program if they enter Q or q
             2. Allow user enter a number print out all even number <= inputted number.
             */
            //while (true)
            //{
            //    var input = Console.ReadLine();
            //    if (input.Equals("Q") || input.Equals("q")) ;
            //    {
            //        break;
            //    }
            //    Console.WriteLine("You have press: {0}", input);
            //}
            //Console.WriteLine("Done");
            int intTemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (int i = 1; i < intTemp; i++)
            {
                if (i%2 != 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
