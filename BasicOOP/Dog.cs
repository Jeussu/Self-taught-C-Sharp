using System;

namespace BasicOOP
{
    public class Dog
    {
        public int size;
        public string breed;
        public string name;

        public Dog(int size, string breed, string name)
        {
            this.size = size;//this references cụ thể tới class dog
            this.breed = breed;
            this.name = name;
        }


        public void bark()
        {
            Console.WriteLine(name + " is a" + breed + ".He barks Ruff, Ruff");
        }
    }
}
