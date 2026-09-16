using WeatherApplication.Database.Context.Context;
using WeatherApplication.Database;
using Microsoft.EntityFrameworkCore;
using WeatherApplication.Database.Repositories.Interfaces;

namespace WeatherApplication.Database.Repositories;

public class WeatherRepository : IWeatherRepository
{
    private readonly AppDbContext _context;

    public WeatherRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IList<string>> GetWeatherAsync(
        CancellationToken cancellationToken = default)
    {
        return await _context.Weathers
            .Select(x => $"{x.City}: {x.Summary}")
            .ToListAsync(cancellationToken);
    }
}