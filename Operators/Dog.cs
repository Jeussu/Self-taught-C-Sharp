using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Dog
    {
        public String Name;
        public String Breed;

        public Dog(String Name, String Breed)
        {
            this.Name = Name;
            this.Breed = Breed;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Dog;
            if (other == null)
                return false;
            if (Name == other.Name && Breed == other.Breed)
                return true;
            return false;
        }

        public void bark ()
        {
            Console.WriteLine("Ruff! Ruff!");
        }
    }
}
