using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Models
{
    [Table("Return")]
    public partial class DBReturn
    {
        public int ID { get; set; }
        public DateTime ReturnCar { get; set; }
        public DateTime ExtensionTime { get; set; }
        public int Fee { get; set; }
    }
}
