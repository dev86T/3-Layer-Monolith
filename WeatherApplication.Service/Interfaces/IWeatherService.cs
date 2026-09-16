namespace Service.ServiceInterfaces;

public interface IWeatherService
{
    public Task<string> GetWeatherAsync(string city);
    public Task<IList<string>> GetWeatherFromDbAsync(CancellationToken cancellationToken = default);
}