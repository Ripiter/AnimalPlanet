using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPlanet
{
    abstract class WildAnimal : Animal
    {
        public bool Hunting { get; set; }
        public WildAnimal()
        {
        }

        public WildAnimal(string name) : base(name)
        {
        }
        public WildAnimal(string name, bool isHunting) : base(name)
        {
            Hunting = isHunting;
        }
    }
}
