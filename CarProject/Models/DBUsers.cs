using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Models
{
    [Table("Users")]
    public partial class DBUsers
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public int? UserPass { get; set; }
        public string AdminName { get; set; }
        public Nullable<int> AdminPass { get; set; }
    }
}
