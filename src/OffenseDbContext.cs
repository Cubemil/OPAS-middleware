using Microsoft.EntityFrameworkCore;
using src.Models;

public class OffenseDbContext : DbContext
{
    public DbSet<OffenseRecord> OffenseRecords { get; set; }

    public OffenseDbContext(DbContextOptions<OffenseDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // automatically adds RecordId to record when added to db
        modelBuilder.Entity<OffenseRecord>()
            .Property(e => e.RecordId)
            .ValueGeneratedOnAdd();

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source = ./Data/offenses.db");
        }
    }
}
