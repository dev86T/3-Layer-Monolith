using Microsoft.Extensions.DependencyInjection;
using Service.ServiceInterfaces;

namespace WeatherApplication.Service;

public static class ServiceConfiguration
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IWeatherService, WeatherService>();
        return services;
    }
}