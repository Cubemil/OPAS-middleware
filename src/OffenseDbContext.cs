using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src
{
    public class OffenseDbContext : DbContext
    {
        public DbSet<DtoOffenseRecord> OffenseRecords { get; set; }

        public OffenseDbContext(DbContextOptions<OffenseDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // automatically adds RecordId to record when added to db
            modelBuilder.Entity<DtoOffenseRecord>()
                .Property(e => e.RecordId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<DtoOffenseRecord>()
                .Property(e => e.RowVersion)
                .IsConcurrencyToken(false);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlite("Data Source = ./Data/offenses.db");
        }
    }
}