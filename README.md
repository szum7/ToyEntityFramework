# ToyEntityFramework

## Setup
1. Create Class Library project: DAL
2. Install NuGet packages in DAL
   - Microsoft.EntityFrameworkCore.SqlServer
   - Microsoft.EntityFrameworkCore.Tools
   - Microsoft.EntityFrameworkCore.Design
3. Add Models folder and some models e.g.: Pulse.cs
4. Add a DB in Microsoft SQL Manager Studio
5. Add the DbContext file with a local connectionstring
```C#
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
```
5. Set DAL as startup and default project in the Package Manager Console and run: ```Add-Migration InitialCreate``` then ```Update-Database```
6. Use the DAL layer in other projects - add the Class Library as Project Reference
