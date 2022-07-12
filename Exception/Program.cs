using System;

namespace Exception1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Allow user enter name and age. If age <0 throw an exception with name and age + "It cannot"
             less than zero
             */
            try
            {
                Console.WriteLine("Enter a name: ");
                var name = Console.ReadLine();
                Console.WriteLine("Enter your age");
                int age = Int32.Parse(Console.ReadLine());
                if (age < 0)
                {
                    throw new CustomException("{0}' s age is {1}. It cannot be less than zero", name, age);
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        public class CustomException : Exception
        {
            public CustomException() : base() { }
            public CustomException(string message) : base(message) { }
            public CustomException(string format, params object[] arguments) : base(string.Format(format, arguments))
            {

            }
        }
    }
}
