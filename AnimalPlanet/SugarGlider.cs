using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPlanet
{
    class SugarGlider : HouseAnimal, ICanFly
    {
        bool flying;
        public SugarGlider()
        {
        }

        public SugarGlider(string name) : base(name)
        {
        }

        public SugarGlider(string name, string owner) : base(name, owner)
        {
        }

        public bool Flying { get => flying; set => flying = value; }
    }
}
