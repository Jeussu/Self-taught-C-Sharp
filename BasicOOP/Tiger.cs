using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    public class Tiger : Feline
    {
        public override void MakeNoise()
        {
            Console.WriteLine("I'm a tiger Grao Grao....");
        }

        public override void Eat()
        {
            Console.WriteLine("I'm a tiger and I eat " + Food);
        }
    }
}
