using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Models
{
    [Table("Rental")]
    public partial class DBRental
    {
        public int ID { get; set; }
        public int CarID { get; set; }
        public int ClientID { get; set; }
        public DateTime OutDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int Fee { get; set; }
    }
}
