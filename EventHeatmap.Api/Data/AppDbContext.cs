using EventHeatmap.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EventHeatmap.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Event> Events { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Map to "events" table explicitly
        modelBuilder.Entity<Event>().ToTable("events");

        // Indexing for faster spatial-like queries (or just common queries)
        modelBuilder.Entity<Event>()
            .HasIndex(e => new { e.Latitude, e.Longitude });
        
        modelBuilder.Entity<Event>()
            .HasIndex(e => e.StartTime);
    }
}
