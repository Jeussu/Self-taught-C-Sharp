using System;

namespace OtherFeatures
{
    //Demo StringInterporation
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "Lionel";
            customer.LastName = "Messi";
            customer.Age = 1;


            Console.WriteLine($"FullName is {customer.FirstName} {customer.LastName}. " +
                $"His age is {customer.Age:D3} {(customer.Age == 1 ? "Year old" : "Years old")}");


            Console.ReadKey();
        }
    }
}
