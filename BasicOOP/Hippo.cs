using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    public class Hippo : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("I'm a hippo Ohhh ohhh....");
        }

        public override void Eat()
        {
            Console.WriteLine("I'm a hippo and I eat " + Food);
        }
    }
}
