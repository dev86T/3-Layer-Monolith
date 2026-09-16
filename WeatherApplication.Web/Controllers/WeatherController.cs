using Microsoft.AspNetCore.Mvc;
using Service.ServiceInterfaces;

namespace WeatherApplication.Web.Controllers;

[ApiController]
[Route("api/v1/weather")]
public class WeatherController : ControllerBase
{
    private readonly IWeatherService _weatherService;

    public WeatherController(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    /// <summary>
    ///     Random weather for the random city
    /// </summary>
    [HttpGet("{city}")]
    public async Task<IActionResult> GetWeather(string city)
    {
        var weather = await _weatherService.GetWeatherAsync(city);

        return Ok(weather);
    }

    /// <summary>
    ///     Constant weather from DB data.
    /// </summary>
    [HttpGet("from-db")]
    public async Task<IActionResult> GetWeatherFromDb(CancellationToken cancellationToken)
    {
        var weather = await _weatherService.GetWeatherFromDbAsync(cancellationToken);

        return Ok(weather);
    }
}