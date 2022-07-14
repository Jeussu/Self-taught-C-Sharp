using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Concurrency
{
    public class ThreadWithParam
    {
        class Student
        {
            public string Name { get; set; }
            public DateTime BirthDay { get; set; }
        }

        //static void Main()
        //{
        //    Thread t1 = new Thread(new ParameterizedThreadStart(Print));
        //    t1.Start(new Student() { Name = "Ronaldo", BirthDay = new DateTime(1985, 05, 17) });

        //    Console.ReadKey();
        //}

        static void Print(object obj)
        {
            Student st = (Student)obj;
            Console.WriteLine(st.Name + "\t" + st.BirthDay.ToShortDateString());
        }
    }


}
