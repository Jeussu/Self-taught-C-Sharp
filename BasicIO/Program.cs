using System;
using System.IO;
using System.Text;

namespace BasicIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
           FileInfo fileInfo = new FileInfo(@"C:\IO\demo.txt");
            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }

            //var fileStream = fileInfo.Open(FileMode.Append, FileAccess.Write);
            //string someText = "This is some text";

            //byte[] someTextInBytes = new UTF8Encoding(true).GetBytes(someText);
            //fileStream.Write(someTextInBytes, 0, someTextInBytes.Length);


            var fileStream2 = fileInfo.OpenRead();
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);

            while(fileStream2.Read(b, 0, b.Length) > 0)
            {
                Console.WriteLine(temp.GetString(b));
            }



            Console.ReadKey();
        }
    }
}
