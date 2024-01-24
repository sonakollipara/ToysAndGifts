using Microsoft.EntityFrameworkCore;
using ToysAndGifts.Models;

namespace ToysAndGifts.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Customers> Customers { get; set; }
    }
}
