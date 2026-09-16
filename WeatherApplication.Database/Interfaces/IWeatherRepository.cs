namespace WeatherApplication.Database.Repositories.Interfaces;

public interface IWeatherRepository
{
    Task<IList<string>> GetWeatherAsync(CancellationToken cancellationToken = default);
}