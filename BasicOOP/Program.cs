using System;

namespace BasicOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog(14, "Bruno", "BullDog");
            //setSize obj d
            d.SetSize(10);
            Console.WriteLine(d.GetSize());
            d.bark();
            //call method
            Console.ReadKey();
        }
    }
}
