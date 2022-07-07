using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[3];
            marks[0] = 10;
            marks[1] = 8;
            marks[2] = 6;

            int[] marks2 = { 10, 8, 6 };
            /*Console.WriteLine(marks[2]);*/ // lấy ra phần tử thứ 2 của mảng
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }

            int[,] a2 = new int[2, 3]
            {
                {1,2, 3},
                {4,5, 6}
            };

            for (int i = 0; i < 2; i++) //access vào mảng 2 chiều
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a2[i, j]);
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
