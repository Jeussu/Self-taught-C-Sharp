using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    public class Cat : Feline
    {
        public override void MakeNoise()
        {
            Console.WriteLine("I'm a cat Meow meow....");
        }

        public override void Eat()
        {
            Console.WriteLine("I'm a cat and I eat " + Food);
        }
    }
}
