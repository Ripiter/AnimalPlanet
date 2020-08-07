using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPlanet
{
    class Dog : HouseAnimal, IBark
    {
        bool isBarking;
        public Dog()
        {
        }

        public Dog(string name) : base(name)
        {
        }

        public Dog(string name, string owner) : base(name, owner)
        {
        }

        public bool Barking { get => isBarking; set => isBarking = value; }
    }
}
