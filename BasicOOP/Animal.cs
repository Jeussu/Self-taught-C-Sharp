using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    public class Animal
    {
        public string Picture { get; set; }
        public string Food { get; set; }
        public int Hunger { get; set; }
        public string Boundaries { get; set; }
        public string Location { get; set; }

        public virtual void MakeNoise()
        {
            Console.WriteLine("Noising....");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Eating");
        }

        public virtual void Roam()
        {
            Console.WriteLine("Roaming...");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }
}
