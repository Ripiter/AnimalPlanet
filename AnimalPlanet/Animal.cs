using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPlanet
{
    abstract class Animal : Entity
    {
        public string Name { get; set; }

        public Animal()
        {

        }

        public Animal(string name)
        {
            this.Name = name;
        }
    }
}
