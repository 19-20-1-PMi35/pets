using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets.Models
{
    class PetsContext: DbContext
    {
        public PetsContext(): base("PetsConnection")
        {

        }

        public DbSet<Types> Types { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Animal> Animals { get; set; }
    }
}
