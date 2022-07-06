using System;

namespace BasicFlow
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i++ < 6)
            {
                Console.WriteLine("Current value is {0}", i);
            }
            Console.WriteLine("\n Do While result");
            i = 1;

            do
            {
                Console.WriteLine("Current value is {0}", i);
            } while (i++ < 6);
            Console.ReadLine();
        }
    }
}
