using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FaceitGraphs_backend.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        //public DbSet<abc> Abc { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}