using System;

namespace AdvanceOOP
{
    public class AddingWrapper
    {//demo overloading
        public int add (int a, int b)
        {
            return a + b;
        }

        public int add(int a, int b, int c)
        {
            return a + b + c;
        }

        public float add(float a, float b, float c, float d)
        {
            return a + b + c + d;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            AddingWrapper aw = new AddingWrapper();
            Console.WriteLine(aw.add (1, 2));
            Console.WriteLine(aw.add(1, 2, 3, 4));

            Console.ReadLine();
        }
    }
}
