using Microsoft.EntityFrameworkCore;
using Web_Project.Model;

namespace Web_Project.Data
{
    public class AppDbContexts : DbContext
    {
        public AppDbContexts(DbContextOptions<AppDbContexts> options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
