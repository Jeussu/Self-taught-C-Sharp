using ClassLibrary1;
using System;

namespace FirstProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            Console.WriteLine("Hello World!"); //in ra màn hình
            Console.WriteLine(obj.HelloFromUniverse());
            Console.ReadKey();// để dừng màn hình
        }
    }
}
