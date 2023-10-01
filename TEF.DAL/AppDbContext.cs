using Microsoft.EntityFrameworkCore;
using TEF.ConsoleApp.Models;

namespace TEF.ConsoleApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pulse> Pulses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string dbName = "ToyEntityFramework1";
                optionsBuilder.UseSqlServer($@"Server=(localdb)\MSSQLLocalDB;Database={dbName};Integrated Security=True;");
            }
        }
    }
}
