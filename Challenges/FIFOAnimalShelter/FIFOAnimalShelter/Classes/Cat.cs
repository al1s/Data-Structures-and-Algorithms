namespace FIFOAnimalShelter.Classes
{
    public class Cat : Animal
    {
        public override string Name { get; set; }
        public override Animal Next { get; set; }
        public Cat(string name)
        {
            Name = name;
        }
    }
}
