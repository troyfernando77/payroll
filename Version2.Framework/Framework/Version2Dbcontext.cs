using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Version2.Data.Models;

namespace Version2.Framework
{
    public class Version2Dbcontext : DbContext
    {
        private readonly IConfiguration configuration;

        public Version2Dbcontext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(this.configuration.GetConnectionString("Default"));

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DTR>().OwnsOne(m => m.Rate);
        }
       
        public DbSet<Messages> Messages { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<DTRSummary> DTRSummaries { get; set; }
        public DbSet<DTRHead> DTRHeads { get; set; }

    }
}
