using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    public class Canine : Animal
    { //animal type like dog
        public override void Roam()
        {
            Console.WriteLine("We go alone");
        }
    }
}
