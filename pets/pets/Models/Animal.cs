using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets.Models
{
    [Table("Animal")]
    class Animal
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public int sizeId { get; set; }
        public Size Size { get; set; }
        public string breed { get; set; }
        public string description { get; set; }
        public int typeId { get; set; }
        public Type Type { get; set; }
        public Order Order { get; set; }
    }
}
