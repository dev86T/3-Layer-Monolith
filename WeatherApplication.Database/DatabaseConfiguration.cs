using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WeatherApplication.Database.Context.Context;
using WeatherApplication.Database.Repositories;
using WeatherApplication.Database.Repositories.Interfaces;

namespace WeatherApplication.Database;

public static class DatabaseConfiguration
{
    public static IServiceCollection AddRepositories(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(
                configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IWeatherRepository, WeatherRepository>();

        return services;
    }
}