using System;

namespace BasicOOP
{
    public class Dog
    {
        private int size;
        public string Breed { get; set; }
        public string Name { get; set; }

        public void SetSize(int s)
        {
            if (s > 0) size = s;
            else Console.WriteLine("You cannot create a supernatural dog");
        }

        public int GetSize()
        {
            return size;
        }

        //public void SetBreed(string breed)
        //{
        //    this.breed = breed;
        //}

        //public string GetBreed()
        //{
        //    return breed;
        //}
        public Dog(int size, string breed, string name)
        {
            SetSize(size);//this references cụ thể tới class dog
            Breed = breed;
            Name = name;
        }


        public void bark()
        {
            Console.WriteLine(Name + " is a" + Breed + ".He barks Ruff, Ruff");
        }
    }
}
