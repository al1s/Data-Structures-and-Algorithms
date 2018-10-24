using System;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        // first animal to be adopted (first in)
        Animal _head = default(Animal);
        // last animal to be adopted (last in)
        Animal _tail = default(Animal);
        public int Size { get; private set; } = 0;
        /// <summary>
        /// Empty shelter constructor
        /// </summary>
        public AnimalShelter()
        {
        }
        /// <summary>
        /// Shelter constructor
        /// </summary>
        /// <param name="animal">Initial animal in the shelter instance</param>
        public AnimalShelter(Animal animal)
        {
            _head = animal;
            _tail = animal;
            Size += 1;
        }
        /// <summary>
        /// Add an animal to the shelter
        /// </summary>
        /// <param name="animal">An animal to be added to the shelter instance</param>
        public void Enqueue(Animal animal)
        {
            if(_head == null)
            {
                _head = animal;
                _tail = animal;
            }
            else
            {
                _tail.Next = animal;
                _tail = animal;
            }
            Size += 1;
        }
        /// <summary>
        /// Adopt the first animal (the most long waiting) from the shelter instance (remove)
        /// </summary>
        /// <returns>An animal to be adopted</returns>
        public Animal Dequeue()
        {
            Animal temp = _head;
            _head = _head.Next;
            temp.Next = null;
            Size -= 1;
            return temp;
        }
        /// <summary>
        /// Adopt the first animal of a given type
        /// </summary>
        /// <param name="animal">Type of the animal to be adopted</param>
        /// <returns>An animal</returns>
        public Animal DequeueWithType(Type animal)
        {
            Animal result = default(Animal);
            Animal temp = default(Animal);
            // if first waiting animal is a given type, return the animal
            if (_head.GetType() == animal)
                return this.Dequeue();
            else
            {
                // keep pointer to the longest waiting animal
                temp = this.Dequeue();
                this.Enqueue(temp);
                while (_head != temp && _head != null)
                {
                    if (_head.GetType() == animal && result == null)
                        result = this.Dequeue();
                    else
                        this.Enqueue(this.Dequeue());
                }
            }
            return result;
        }
        /// <summary>
        /// Adopt the first available animal in the shelter instance
        /// </summary>
        /// <returns>The animal to be adopted</returns>
        public Animal DequeueWithType()
        {
            return this.Dequeue();
        }
    }
}
