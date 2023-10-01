using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;
using TEF.DAL.Models;

namespace TEF.ConsoleApp
{
    public class AppDbContext : DbContextWithTriggers
    {
        public DbSet<Pulse> Pulses { get; set; }
        public DbSet<Person> Persons { get; set; }

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
