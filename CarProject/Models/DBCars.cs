using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Models
{
    [Table("Cars")]
    public partial class DBCars
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string RegNumber { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        
    }
}
