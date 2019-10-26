using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets.Models
{
    [Table("Order")]
    class Order
    {
        public int id { get; set; }
        public string surname { get; set; }
        public string pnone { get; set; }
        public string animalId { get; set; }
        public Animal Animal { get; set; }
    }
}
