namespace FIFOAnimalShelter.Classes
{
    public class Snake : Animal
    {
        public override string Name { get; set; }
        public override Animal Next { get; set; }
        public Snake(string name)
        {
            Name = name;
        }
    }
}
