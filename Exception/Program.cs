using System;

namespace Exception1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter HttpRequestCode: ");
            var httpRequestCode = Console.ReadLine();

            try
            {
                throw new Exception(httpRequestCode.ToString());
            }
            // demo exception fillter
            catch (Exception e) when (e.Message.Equals("400"))
            {
                Console.WriteLine("Bad Request");
            }
            catch (Exception e) when (e.Message.Equals("401"))
            {
                Console.WriteLine("Unauthoroizied");
            }
            catch (Exception e) when (e.Message.Equals("200"))
            {
                Console.WriteLine("Successfull");
            }
            //catch (Exception e) 
            //{
            //    if (e.Message.Equals("400"))
            //    {
            //        Console.WriteLine("Bad Request");
            //    }
            //    else if (e.Message.Equals("401"))
            //    {
            //        Console.WriteLine("Unauthoroizied");
            //    }
            //    else if (e.Message.Equals("200"))
            //    {
            //        Console.WriteLine("Successfull");
            //    }
            //    else
            //        throw e;
        }
        }
    }

