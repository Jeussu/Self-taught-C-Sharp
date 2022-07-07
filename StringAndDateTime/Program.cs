using System;
using System.Globalization;

namespace StringAndDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime dt = new DateTime(2030, 02, 26);
            //Console.WriteLine("dt's day of week: " + dt.DayOfWeek); // lấy về ngày đó trong tuần
            //Console.WriteLine("dt's day of year: " + dt.DayOfYear); // lấy về ngày thứ n trong năm
            //Console.WriteLine("dt: " + dt);

            // get now time
            //DateTime now = DateTime.Now;
            //Console.WriteLine("now is: " + now);

            //DateTime utcTime = DateTime.UtcNow;
            //Console.WriteLine("Utc is: " + utcTime);

            DateTime dt = new DateTime(2030, 02, 26, 5, 30, 40);

            Console.WriteLine(dt.ToString("d", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(dt.ToString("d", CultureInfo.CreateSpecificCulture("vi-VN")));
            Console.WriteLine("--Long date--");
            Console.WriteLine(dt.ToString("D", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(dt.ToString("D", CultureInfo.CreateSpecificCulture("vi-VN")));


            Console.WriteLine("------------");
            Console.WriteLine(dt.ToString("f", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(dt.ToString("f", CultureInfo.CreateSpecificCulture("vi-VN")));
            Console.WriteLine("--Full datetime--");
            Console.WriteLine(dt.ToString("F", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(dt.ToString("F", CultureInfo.CreateSpecificCulture("vi-VN")));

            Console.WriteLine("------------");
            Console.WriteLine(dt.ToString("t", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(dt.ToString("t", CultureInfo.CreateSpecificCulture("vi-VN")));
            Console.WriteLine("--Full time--");
            Console.WriteLine(dt.ToString("T", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(dt.ToString("T", CultureInfo.CreateSpecificCulture("vi-VN")));

            //Demo convert string sang datetime
            /*TryParse*/
            String str1 = "02/26/2030";
            DateTime tmp1;
            DateTime.TryParse(str1, CultureInfo.InvariantCulture, DateTimeStyles.None, out tmp1);
            Console.WriteLine(tmp1);

            /*TryParseExact*/

            String str2 = "20302602 05:30:20";
            DateTime.TryParseExact(str2, "yyyyddMM hh:mm:ss", CultureInfo.InvariantCulture,
                DateTimeStyles.None, out tmp1);
            Console.WriteLine(tmp1);


            Console.ReadLine();
        }
    }
}
