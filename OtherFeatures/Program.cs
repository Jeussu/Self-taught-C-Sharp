using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OtherFeatures
{
    //Demo StringInterporation

    internal class Program
    {
        // publisher
        // PrintHelper class that prints intergers in a format.
        // It includes a beforePrintEvent to notify the subscriber of beforePrint event before it going to print the numbers
        public class PrintHelper
        {
            public delegate void BeforePrint();
            //Declare event of type delegate
            public event BeforePrint beforePrintEvent;
            public void PrintNumber(int num)
            {
                // call delegate method bẻoe going to print
                if (beforePrintEvent != null)
                    beforePrintEvent();

                Console.WriteLine("Number: {0, 12:N0}", num);

            }
        }
        //subcriber 
        class Number
        {
            private PrintHelper _printHelper;
            private int _value;

            public Number(int val)
            {
                _value = val;

                _printHelper = new PrintHelper();
                //subcriber to beforePrintEvent event
                _printHelper.beforePrintEvent += printHelper_beforePrintEvent;
            }

            void printHelper_beforePrintEvent()
            {
                Console.WriteLine("BeforePrintEventHandle: PrintHepler is going to print a value");
            }

            public void PrintNumber()
            {
                _printHelper.PrintNumber(_value);
            }
        }

        static void Main(string[] args)
        {
            Number myNumber = new Number(100000); 
            myNumber.PrintNumber();
            Console.ReadKey();
        }

    }
}
