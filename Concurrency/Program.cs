using System;
using System.Threading;
using System.Threading.Tasks;

namespace Concurrency
{
    public class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Go to main");
        //    Method1();
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    Console.ReadLine();
        //}

        //private static void Method1()
        //{
        //    HelloTask();
        //    Console.WriteLine("Finish calling HelloTask");
        //}

        //private static void HelloTask()
        //{
        //    Thread.Sleep(5000);
        //    Console.WriteLine("Hello");
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Go to main");
            Method1();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        private static async void Method1()
        {
            await Task.Run(new Action(HelloTask));
            Console.WriteLine("Finish calling HelloTask");
        }

        private static void HelloTask()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Hello");
        }
    }
}
