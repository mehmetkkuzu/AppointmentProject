using CaserGroup.Automotive.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaserGroup.Automotive.Data.DataContext
{
    public class EntityDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Appointment> Appointment { get; set; }


        public EntityDbContext() : base("name=CaserGroupDbContext")
        {
        }
    }
}
