using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    public class Context : DbContext
    {
        private readonly string connectionString;
        public Context() : base("Server=DESKTOP-RM1NBDJ;Database=hw10;Trusted_Connection=True;")
        {
        }
        public DbSet<Boss> Bosses { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<WorkOffice> WorkOffices { get; set; }

    }
}
