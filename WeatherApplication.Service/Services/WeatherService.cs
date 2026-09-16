using Service.ServiceInterfaces;
using WeatherApplication.Database.Repositories.Interfaces;

namespace WeatherApplication.Service;

public class WeatherService : IWeatherService
{
    private readonly Random _random = new();
    private readonly IWeatherRepository _weatherRepository;

    public WeatherService(IWeatherRepository weatherRepository)
    {
        _weatherRepository = weatherRepository;
    }

    public Task<string> GetWeatherAsync(string city)
    {
        var summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild",
            "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        var temperature = _random.Next(-20, 41);
        var summary = summaries[_random.Next(summaries.Length)];

        return Task.FromResult(
            $"{city}: {temperature}°C, {summary}"
        );
    }

    public async Task<IList<string>> GetWeatherFromDbAsync(CancellationToken cancellationToken = default)
    {
        return await _weatherRepository.GetWeatherAsync(cancellationToken);
    }
}