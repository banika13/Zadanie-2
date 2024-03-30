using Microsoft.EntityFrameworkCore;

namespace Zadanie2
{
    internal class AppContext : DbContext
    {
        public DbSet<FIO> fios { get; set; } = null!;

        public AppContext() 
        { 
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;password=govno;database=sys;",
                new MySqlServerVersion(new Version(8, 0, 34)));
        }
    }
}
