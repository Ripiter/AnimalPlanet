using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPlanet
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new AnimalContext())
            {
                var results = ctx.Animals;

                foreach (Animal animal in results)
                {
                    if(animal is ICanFly)
                        Console.WriteLine(animal.Name + " is flying " + ((ICanFly)animal).Flying );
                }

                ctx.SaveChanges();
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
