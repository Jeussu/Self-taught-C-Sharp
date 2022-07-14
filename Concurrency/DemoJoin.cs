using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Concurrency
{
    public class DemoJoin
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(MethodA);
            Thread t2 = new Thread(MethodB);
            Thread t3 = new Thread(MethodC);
            
            t1.Start();
            t2.Start();
            
            t2.Join();

            t3.Start();
        }

        static void MethodA()
        {
            for (int i = 0; i < 10000; i++)
                Console.WriteLine("0");            
        }
        static void MethodB()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine("1");
        }

        static void MethodC()
        {
            for (int i = 0; i < 100000; i++)
                Console.WriteLine("2");
        }
    }
}
