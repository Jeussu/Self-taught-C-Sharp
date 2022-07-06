using System;

namespace BasicFlow
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i<10)
            {
                Console.WriteLine(i);
                i++;
            }
            i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
            Console.ReadLine();
        }
    }
}
