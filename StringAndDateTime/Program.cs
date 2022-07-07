using System;

namespace StringAndDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2030, 02, 26);
            Console.WriteLine("dt's day of week: " + dt.DayOfWeek); // lấy về ngày đó trong tuần
            Console.WriteLine("dt's day of year: " + dt.DayOfYear); // lấy về ngày thứ n trong năm
            Console.WriteLine("dt: " + dt);

            // get now time
            DateTime now = DateTime.Now;
            Console.WriteLine("now is: " + now);

            DateTime utcTime = DateTime.UtcNow;
            Console.WriteLine("Utc is: " + utcTime);


            Console.ReadLine();
        }
    }
}
