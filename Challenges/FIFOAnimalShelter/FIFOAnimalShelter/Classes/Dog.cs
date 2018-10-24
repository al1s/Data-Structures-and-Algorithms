namespace FIFOAnimalShelter.Classes
{
    public class Dog : Animal
    {
        public override string Name { get; set; }
        public override Animal Next { get; set; }
        public Dog(string name)
        {
            Name = name;
        }
    }
}
