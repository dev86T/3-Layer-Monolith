using Microsoft.EntityFrameworkCore;
using WeatherApplication.Database.Entities;

namespace WeatherApplication.Database.Context.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Weather> Weathers => Set<Weather>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Weather>().HasData(
            new Weather
            {
                Id = 1,
                City = "Stockholm",
                Summary = "Cold"
            },
            new Weather
            {
                Id = 2,
                City = "Moscow",
                Summary = "Freezing"
            },
            new Weather
            {
                Id = 3,
                City = "Dubai",
                Summary = "Hot"
            }
        );
    }
}