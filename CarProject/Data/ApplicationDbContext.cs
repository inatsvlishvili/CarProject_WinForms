using CarProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=Car_Project;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<DBClients> Client { get; set; }
        public DbSet<DBUsers> User { get; set; }
        public DbSet<DBCars> Car { get; set; }
        public DbSet<DBRental> Rentals { get; set; }
        public DbSet<DBReturn> Returns { get; set; }
    }
}
