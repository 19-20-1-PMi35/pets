using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets.Models
{
    [Table("Types")]
    class Types
    {
        public int id { get; set; }
        public string type { get; set; }
        public ICollection<Animal> Animals { get; set; }

        public Types()
        {
            Animals = new Collection<Animal>();
        }
    }
}
