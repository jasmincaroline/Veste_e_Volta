using Microsoft.EntityFrameworkCore;
using VesteEVolta.Models;

namespace VesteEVolta.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<TbCategory> Categories { get; set; }
    }
}
