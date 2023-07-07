using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Primary_Health_Care.Models;
using Microsoft.AspNetCore.Identity;

namespace Primary_Health_Care.Data
{
    public class ApplicationDbContext:IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Define your DbSet properties here for each entity you want to map to the database
        //public DbSet<Log_In> login { get; set; }

        // Override OnModelCreating method if you need to configure entity mappings
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity mappings here
        }*/
    }
}
