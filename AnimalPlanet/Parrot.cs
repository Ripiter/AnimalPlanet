using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPlanet
{
    class Parrot : HouseAnimal, ICanFly
    {
        bool flying;
        public Parrot()
        {
        }

        public Parrot(string name) : base(name)
        {
        }

        public Parrot(string name, string owner) : base(name, owner)
        {
        }

        public bool Flying { get => flying; set => flying = value; }
    }
}
