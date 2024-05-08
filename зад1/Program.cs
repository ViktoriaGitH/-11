using System;

namespace зад1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet[] pets = new Pet[]
        {
            new Dog { Name = "Али", Age = 3 },
            new Dog { Name = "Макс", Age = 5 },
            new Cat { Name = "Луси", Age = 2 },
            new Cat { Name = "Пухи", Age = 4 },
            new Dog { Name = "Шаро", Age = 2 }
        };

            foreach (var pet in pets)
            {
                Console.WriteLine(pet.Info());
                Console.WriteLine($"Звук: {pet.GetSound()}");
                Console.WriteLine();
            }
        }
    }


    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual string GetSound()
        {
            return "Unknown";
        }

        public virtual string Info()
        {
            return $"Име: {Name}, Години: {Age}";
        }
    }

    class Cat : Pet
    {
        public override string GetSound()
        {
            return "Мяу";
        }

        public override string Info()
        {
            return $"Котка - {base.Info()}";
        }
    }

    class Dog : Pet
    {
        public override string GetSound()
        {
            return "Бау";
        }

        public override string Info()
        {
            return $"Куче - {base.Info()}";
        }
    }

}