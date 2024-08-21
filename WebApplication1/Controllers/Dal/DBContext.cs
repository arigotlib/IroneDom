using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace OcharHasfarim.DAL
{
    public class DBContext : DbContext
    {
        public DBContext(string connectionString) : base(GetOptions(connectionString))
        {
            Database.EnsureCreated();
            if (Amazons.Count() == 0)
            {
                Seed();
            }
        }
        private void Seed()
        {
            Amazon amazon = new Amazon
            {
               Name = "Elektric"
            };
            Amazons.Add(amazon);
            SaveChanges();
        }
        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }
        public DbSet<Amazon> Amazons { get; set; }

    }
}
