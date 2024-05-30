using Microsoft.EntityFrameworkCore;
using backend.Models;

// manages connection to database
// represents tables as DbSet properties (entity framework)
public class OffenseDbContext : DbContext
{
    public OffenseDbContext(DbContextOptions<OffenseDbContext> options) : base(options)
    {

    }

    public DbSet<OffenseRecord> OffenseRecords { get; set; }

}