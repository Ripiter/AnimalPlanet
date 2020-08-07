using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPlanet
{
    abstract class HouseAnimal : Animal
    {
        public string Owner { get; set; }
        public HouseAnimal()
        {
        }

        public HouseAnimal(string name) : base(name)
        {

        }

        public HouseAnimal(string name, string owner) : base(name)
        {
            this.Owner = owner;
        }
    }
}
