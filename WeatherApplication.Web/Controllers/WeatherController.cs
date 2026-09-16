using Microsoft.AspNetCore.Mvc;
using Service.ServiceInterfaces;

namespace WeatherApplication.Web.Controllers;

[ApiController]
[Route("weather")]
public class WeatherController : ControllerBase
{
    private readonly IWeatherService _weatherService;

    public WeatherController(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    [HttpGet("{city}")]
    public async Task<IActionResult> GetWeather(string city)
    {
        var weather = await _weatherService.GetWeatherAsync(city);

        return Ok(weather);
    }

    [HttpGet("api/v1/weather-from-db")]
    public async Task<IActionResult> GetWeatherFromDb(CancellationToken cancellationToken)
    {
        var weather = await _weatherService.GetWeatherFromDbAsync(cancellationToken);
        
        return Ok(weather);
    }
}