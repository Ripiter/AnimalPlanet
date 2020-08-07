using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPlanet
{
    class Wolf : WildAnimal, IBark
    {
        bool isBarking;
        public Wolf()
        {
        }

        public Wolf(string name) : base(name)
        {
        }

        public Wolf(string name, bool isHunting) : base(name, isHunting)
        {
        }

        public bool Barking { get => isBarking; set => isBarking = value; }
    }
}
