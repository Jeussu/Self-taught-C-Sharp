using System;

namespace BasicOOP
{
    public class Lion : Feline
    {
        public override void MakeNoise()
        {
            Console.WriteLine("I'm a lion Gruuu Gruuu...");
        }

        public override void Eat()
        {
            Console.WriteLine("I'm a lion and I eat" + Food);
        }
    }
}
