using System;
using System.Linq;

namespace DeclarationAndAssigment
{
    public class Program
    {
        class Employee
        {
            int Id;
            byte Title;
            String FirstName;
            String LastName;
            DateTime Birthday;
            char Gender;
            short CountryId;
            int CityId;
            String Address;
            String Email;
            String Phone;
            String AccountNumber;
            String TaxNo;
            String SocialNumber;
            decimal Salary;
        }
        static void Main(string[] args)
        {
            //int size = 0;
            //int Size = 0;
            //int SIZE = 0;
            //int from = 0;
            //Console.WriteLine("from " + from);

            //String matchInfo = "CR7&*&^*&^*&%* vs M10%^%&^$%*&^";
            //var digits = from c in matchInfo //linq query
            //             where Char.IsDigit(c) || Char.IsWhiteSpace(c) || Char.IsLetter(c) //get kí tự và khoảng trắng
            //             select c;
            //foreach (Char d in digits)
            //{
            //    Console.WriteLine(d);
            //}
            //int i = 0;
            //Console.WriteLine(i);
            //var i = 100;

            //var j = "Hello World";
            //string[] words = { "aPPLE", "BLUeBeRrY", "cHeRry" };
            /* Outputs:
             Uppercase: APPLE, Lowercase: apple
             Uppercase: BLUEBERRY, Lowercase: blueberry
             */
            //var upperLowerWords =
            //    from w in words
            //    select new { Upper = w.ToUpper(), Lower = w.ToLower() };

            ////Execute the query
            //foreach (var ul in upperLowerWords)
            //{
            //    Console.WriteLine("Uppercase: {0}, Lowercase: {1}", ul.Upper, ul.Lower);
            //}
            dynamic d;
            d = "Hello word";
            Console.WriteLine(d.GetType());
            d = 100;
            Console.WriteLine(d.GetType());
            Console.ReadKey();
        }
    }
}
