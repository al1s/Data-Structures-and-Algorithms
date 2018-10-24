using System;
using Xunit;
using FIFOAnimalShelter.Classes;

namespace FIFOAnimalShelterTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Test whether can create a shelter
        /// </summary>
        [Fact]
        public void CanCreateShelter()
        {
            Cat cat1 = new Cat("Fluffy");
            AnimalShelter animalShelter = new AnimalShelter(cat1);
            Assert.IsType<AnimalShelter>(animalShelter);
            Assert.Equal(1, animalShelter.Size);
        }
        /// <summary>
        /// Test whether can  add an animal to the shelter
        /// </summary>
        [Fact]
        public void CanEnqueueAnimal()
        {
            Cat cat1 = new Cat("Fluffy");
            Cat cat2 = new Cat("Kitty");
            AnimalShelter animalShelter = new AnimalShelter(cat1);
            animalShelter.Enqueue(cat2);
            Assert.Equal(2, animalShelter.Size);
        }
        /// <summary>
        /// Test whether can add two animals of different type to the shelter
        /// </summary>
        [Fact]
        public void CanEnqueueTwoAnimals()
        {
            Cat cat1 = new Cat("Fluffy");
            Cat cat2 = new Cat("Kitty");
            Dog dog1 = new Dog("Taco");
            AnimalShelter animalShelter = new AnimalShelter(cat1);
            animalShelter.Enqueue(cat2);
            animalShelter.Enqueue(dog1);
            Assert.Equal(3, animalShelter.Size);
        }
        /// <summary>
        /// Test whether can  retrieve first longest waiting animal (cat)
        /// </summary>
        [Fact]
        public void CanDequeueFirstAnimal()
        {
            Cat cat1 = new Cat("Fluffy");
            Cat cat2 = new Cat("Kitty");
            Dog dog1 = new Dog("Taco");
            AnimalShelter animalShelter = new AnimalShelter(cat1);
            animalShelter.Enqueue(cat2);
            animalShelter.Enqueue(dog1);
            Animal someAnimal = animalShelter.DequeueWithType();
            Assert.Equal(2, animalShelter.Size);
            Assert.IsType<Cat>(someAnimal);
        }
        /// <summary>
        /// Test whether can retrieve two longest waiting animals
        /// </summary>
        [Fact]
        public void CanDequeueFirstAndSecondAnimal()
        {
            Cat cat1 = new Cat("Fluffy");
            Cat cat2 = new Cat("Kitty");
            Dog dog1 = new Dog("Taco");
            AnimalShelter animalShelter = new AnimalShelter(cat1);
            animalShelter.Enqueue(cat2);
            animalShelter.Enqueue(dog1);
            Animal someAnimal = animalShelter.DequeueWithType();
            Animal anotherAnimal = animalShelter.DequeueWithType();
            Assert.Equal(1, animalShelter.Size);
        }
        /// <summary>
        /// Test whether can retrieve a dog
        /// </summary>
        [Fact]
        public void CanDequeueFirstAnimalOfTypeDog()
        {
            Cat cat1 = new Cat("Fluffy");
            Cat cat2 = new Cat("Kitty");
            Dog dog1 = new Dog("Taco");
            AnimalShelter animalShelter = new AnimalShelter(cat1);
            animalShelter.Enqueue(cat2);
            animalShelter.Enqueue(dog1);
            Animal someAnimal = animalShelter.DequeueWithType(typeof(Dog));
            Assert.IsType<Dog>(someAnimal);
        }
        /// <summary>
        /// Test whether can retrieve a cat
        /// </summary>
        [Fact]
        public void CanDequeueFirstAnimalOfTypeCat()
        {
            Cat cat1 = new Cat("Fluffy");
            Cat cat2 = new Cat("Kitty");
            Dog dog1 = new Dog("Taco");
            AnimalShelter animalShelter = new AnimalShelter(cat1);
            animalShelter.Enqueue(cat2);
            animalShelter.Enqueue(dog1);
            Animal someAnimal = animalShelter.DequeueWithType(typeof(Cat));
            Assert.IsType<Cat>(someAnimal);
        }
        /// <summary>
        /// Test whether can't retrieve an animal of type non existent in the shelter
        /// </summary>
        [Fact]
        public void CannotDequeueNonExistentAnimal()
        {
            Cat cat1 = new Cat("Fluffy");
            AnimalShelter animalShelter = new AnimalShelter(cat1);
            Animal someAnimal = animalShelter.DequeueWithType(typeof(Snake));
            Assert.Null(someAnimal);
        }
    }
}
