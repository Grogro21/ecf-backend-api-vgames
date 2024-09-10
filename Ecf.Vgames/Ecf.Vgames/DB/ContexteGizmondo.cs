using Ecf.Vgames.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecf.Vgames.DB
{
    public class ContexteGizmondo:DbContext
    {
        public DbSet<Gizmondos> Gizmondos { get; set; }

        public DbSet<Publisher> Publishers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=db_gizmondo; Trusted_Connection=True;");
        }
    }
}
