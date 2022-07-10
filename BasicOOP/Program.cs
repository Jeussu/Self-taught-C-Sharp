using System;

namespace BasicOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Dog d = new Dog(14, "Bruno", "BullDog");
            ////setSize obj d
            //d.SetSize(10);
            //Console.WriteLine(d.GetSize());
            //d.bark();
            ////call method
            ///
            //Lion leo = new Lion();
            //leo.Food = "Meat";

            //leo.MakeNoise();
            //leo.Eat();
            //leo.Roam();

            //Animal animal1;
            //Animal animal2;
            //Animal animal3;

            //animal1 = new Lion();
            //animal2 = new Cat();
            //animal3 = new Wolf();

            //animal1.Eat();
            //animal1.MakeNoise();
            //animal1.Roam();

            //animal2.Eat();
            //animal2.MakeNoise();
            //animal2.Roam();

            //animal3.Eat();
            //animal3.MakeNoise();
            //animal3.Roam();

            Cat Tom = new Cat();
            Tom.Roam();
            Tom.BeFriendly();
            Tom.Play();

            Console.ReadKey();
        }
    }
}
