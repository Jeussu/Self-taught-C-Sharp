using System;

namespace BasicOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog(14, "Bruno", "BullDog");

            d.bark();//call method
            Console.ReadKey();
        }
    }
}
