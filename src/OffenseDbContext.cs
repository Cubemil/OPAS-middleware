using Microsoft.EntityFrameworkCore;
using src.Models;

// manages connection to database
// represents tables as DbSet properties (entity framework)
public class OffenseDbContext : DbContext
{
    public OffenseDbContext(DbContextOptions<OffenseDbContext> options) : base(options)
    {

    }

    public DbSet<OffenseRecord> OffenseRecords { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source = ./Data/offenses.db");
        }
    }

}