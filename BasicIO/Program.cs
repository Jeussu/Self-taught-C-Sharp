using System;
using System.IO;

namespace BasicIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\IO\demo.txt";
            Console.WriteLine(Path.GetDirectoryName(path1));
            Console.WriteLine(Path.GetFileName(path1));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path1));
            Console.WriteLine(Path.GetFullPath("."));
        }
    }
}
