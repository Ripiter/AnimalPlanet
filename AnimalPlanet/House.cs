using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPlanet
{
    class House : Entity
    {
        public House()
        {

        }
        
        public List<Animal> Animals { get; set; }
        public List<ICanFly> Flying { get; set; }
    }
}
