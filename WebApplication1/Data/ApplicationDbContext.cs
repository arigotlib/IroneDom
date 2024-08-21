using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using WebApplication1.Models;
namespace OcharHasfarim.Data
{
    public class ApplicationDbContext : DbContext
    {
        //constractor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<WebApplication1.Models.Amazon> amazons { get; set; } = default!;
        public DbSet<WebApplication1.Models.Shops> alis { get; set; } = default!;
        
    }
}