using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OtherFeatures
{
    //Demo StringInterporation

    internal class Program
    {
        static void Main(string[] args)
        {

            //demo anonymous types
            var player = new
            {
                firstName = "Tien Dung",
                lastName = "Bui"
            };

            PrintName(player);
            Console.ReadKey();
        }
        public static void PrintName(dynamic o)
        {

            Console.WriteLine("Player name is {0} {1}", o.firstName, o.lastName);
        }
    }
}
