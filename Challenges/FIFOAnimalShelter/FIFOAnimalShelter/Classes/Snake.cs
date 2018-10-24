using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    class Snake : Animal
    {
        public override string Name { get; set; }
        public override Animal Next { get; set; }
        public Snake(string name)
        {
            Name = name;
        }
    }
}
