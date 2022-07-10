using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    public class Wolf : Canine
    {
        public override void MakeNoise()
        {
            Console.WriteLine("I'm a wolf uhhhh uhhhh....");
        }

        public override void Eat()
        {
            Console.WriteLine("I'm a wolf and I eat " + Food);
        }
    }
}
