using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    public class Feline : Animal
    {
        public override void Roam()
        {//override + virtual ở lớp cha
            Console.WriteLine("We go in the pack");
        }

    }
}
