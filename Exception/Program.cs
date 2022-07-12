using System;

namespace Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Try Catch demo 
             Allow user enter 2 numbers and try catch divide zero.
            See properties of an exception.
             */
            Console.WriteLine("Please enter 2 numbers:");
            try
            {
                int number1 = Int32.Parse(Console.ReadLine());
                int number2 = Int32.Parse(Console.ReadLine());

                int result = number1 / number2;
                Console.WriteLine("Number1 is {0}, number2 is {1}, result is {2}", number1, number2, result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("StackTrace: {0}", e.StackTrace);//nơi diễn ra exception
                Console.WriteLine("TargetSite: {0}", e.TargetSite);// chỉ ra method gây ra exception
                Console.WriteLine("InnerException: {0}", e.InnerException);
            }
            Console.ReadLine();
        }
    }
}
