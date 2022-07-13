using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OtherFeatures
{
    //Demo StringInterporation

    internal class Program
    {
        public delegate void Print(int value);
        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0, -12:NO}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }

        public static void PrintHelper(Print delegateFunction, int numberToPrint)
        {
            delegateFunction(numberToPrint);
        }

        static void Main(string[] args)
        {

            //demo Delegate
            // passing a method as a parameter to another method.
            PrintHelper(PrintNumber, 1000);
            PrintHelper(PrintMoney, 200);
            Console.ReadKey();
        }

    }
}
