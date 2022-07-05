using System;

namespace Operators
{
    public class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            int i = 10;

            j = i++;
            Console.WriteLine("j: " + j + "i:" + i);

            Dog d1 = new Dog("Dog1", "G1");
            Dog d2 = new Dog("Dog1", "G1");
            Console.WriteLine(Object.ReferenceEquals(d1, d2));
            Console.WriteLine(d1.Equals(d2));
            Console.ReadKey();
        }
    }
}
