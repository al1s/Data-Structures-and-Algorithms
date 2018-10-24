using FIFOAnimalShelter.Classes;
using System;

namespace FIFOAnimalShelter
{
    internal class Program
    {
        public static void FIFOAnimalShelter()
        {
            Cat cat1 = new Cat("Fluffy");
            Cat cat2 = new Cat("Kitty");
            Dog dog1 = new Dog("Taco");
            Dog dog2 = new Dog("Zuzu");
            Dog dog3 = new Dog("Pepe");

            AnimalShelter animalShelter = new AnimalShelter(cat1);
            animalShelter.Enqueue(cat2);
            animalShelter.Enqueue(dog1);
            animalShelter.Enqueue(dog2);
            animalShelter.Enqueue(dog3);
            Animal someAnimal = animalShelter.DequeueWithType(typeof(Dog));
            Console.WriteLine($"The first available {someAnimal.GetType().Name} is called {someAnimal.Name}");
            someAnimal = animalShelter.DequeueWithType(typeof(Cat));
            Console.WriteLine($"The first available {someAnimal.GetType().Name} is called {someAnimal.Name}");
            someAnimal = animalShelter.DequeueWithType(typeof(Snake));
            Console.WriteLine($"The first available Snake is {(someAnimal != null ? someAnimal.Name : "N/A")}");
            someAnimal = animalShelter.DequeueWithType();
            Console.WriteLine($"The first available animal is a {someAnimal.GetType().Name} with a name {someAnimal.Name}");
        }

        private static void Main(string[] args)
        {
            FIFOAnimalShelter();
            Console.ReadLine();
        }
    }
}
