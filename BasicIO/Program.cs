using System;
using System.IO;

namespace BasicIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path1 = @"C:\IO\demo.txt";
            //Console.WriteLine(Path.GetDirectoryName(path1));
            //Console.WriteLine(Path.GetFileName(path1));
            //Console.WriteLine(Path.GetFileNameWithoutExtension(path1));
            //Console.WriteLine(Path.GetFullPath("."));

            string path1 = @"C:\IO";

            DirectoryInfo di = new DirectoryInfo(path1);

            if (!di.Exists)
            {
                di.Create();
            }

            string path2 = @"C:\IO\Path";
            string path3 = @"C:\IO\DirectoryInfo";
            DirectoryInfo di2 = new DirectoryInfo(path2);

            if (!di2.Exists)
            {
                di2.Create();
            }

            DirectoryInfo di3 = new DirectoryInfo(path3);

            if (!di3.Exists)
            {
                di3.Create();
            }

            //di.Delete(true);

            var directories = di.GetDirectories();
            foreach (var d in directories)
            {
                var files = d.GetFiles();
                    foreach (var f in files)
                {
                    Console.WriteLine(String.Format("{0} folder has {1} file", d, f));
                }
            }

            Console.WriteLine("Done");

            Console.ReadKey();
        }
    }
}
