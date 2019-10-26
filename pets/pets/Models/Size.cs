using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets.Models
{
    [Table("Size")]
    class Size
    {
        public int id { get; set; }
        public string size { get; set; }
        public ICollection<Animal> Animals { get; set; }

        public Size()
        {
            Animals = new Collection<Animal>();
        }
    }
}
