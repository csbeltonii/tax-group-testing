using Microsoft.EntityFrameworkCore;
using TaxGroupTest.Models;

namespace TaxGroupTest.Data
{
    public class Database : DbContext
    {
        public DbSet<TaxRate> TaxRates { get; set; }
        public DbSet<TaxGroup> TaxGroups { get; set; }
        public DbSet<TaxGrouping> TaxGroupings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=AVALON\\SQLEXPRESS;Database= TaxGroupTestDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
                );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TaxGroupConfiguration());
            modelBuilder.ApplyConfiguration(new TaxRateConfiguration());
            modelBuilder.ApplyConfiguration(new TaxGroupingConfiguration());
        }
    }
}
