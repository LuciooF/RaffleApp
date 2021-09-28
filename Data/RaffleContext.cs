using Microsoft.EntityFrameworkCore;
using RaffleApp.Domain;

namespace RaffleApp
{
    public class RaffleContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server = (localdb)\\mssqllocaldb; Database = RaffleDB; Trusted_Connection = True;");

        }
    }
}
