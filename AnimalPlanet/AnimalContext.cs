using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPlanet
{
    class AnimalContext : DbContext
    {
        public AnimalContext() : base("name=AnimalDB")
        {
            Database.SetInitializer<AnimalContext>(new DropCreateDatabaseIfModelChanges<AnimalContext>());
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<House> House { get; set; }
    }
}
