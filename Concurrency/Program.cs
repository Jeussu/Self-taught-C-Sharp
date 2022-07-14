using System;
using System.Threading;

namespace Concurrency
{
    // 1. Create Thread perform method without param
    // 2. Create Thread perform method with param
    // 3. Using Join method.
    public class Program
    {
        static void MethodA()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine("0");           
        }

        static void MethodB()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine("1");
        }

        //static void Main(string[] args)
        //{
        //    Thread t = new Thread(new ThreadStart(MethodA));
        //    t.Start();
        //    MethodB();
        //}
    }
}
