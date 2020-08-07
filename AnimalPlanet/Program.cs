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
                var parrot = new Parrot("Captain", "Steve");
                var parrot2 = new Parrot("Jack", "Steve");
                var parrot3 = new Parrot("Sparrow", "Steve");

                ctx.Animals.Add(parrot);
                ctx.Animals.Add(parrot2);
                ctx.Animals.Add(parrot3);

                ctx.SaveChanges();
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
