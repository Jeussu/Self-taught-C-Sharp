using System;

namespace BasicFlow
{
    public class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i + 1);
            //}
            string[] names = new string[] { "C.Ronaldo", "Messi" };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            } 
            Console.ReadLine();
        }
    }
}
