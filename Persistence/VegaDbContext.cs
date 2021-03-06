using Microsoft.EntityFrameworkCore;
using vega2.Models;

namespace vega2.Persistence
{
    public class VegaDbContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
         : base(options)
        {
        }

    }
}