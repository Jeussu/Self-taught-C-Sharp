using System;
using System.IO;
using System.Text;

namespace BasicIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (StreamWriter streamWriter = new StreamWriter(@"C:\IO\demo2.txt"))
            //{
            //    streamWriter.WriteLine("Let it be");
            //    streamWriter.WriteLine("Tobe or not tobe");
            //}

            using (StreamReader streamReader = new StreamReader(@"C:\IO\demo2.txt"))
            {
                string s = "";
              while((s = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
