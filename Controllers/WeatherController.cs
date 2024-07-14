using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class WeatherController : ControllerBase
{
    private readonly WeatherService _weatherService;

// injeta o serviço de previsão do tempo
    public WeatherController(WeatherService weatherService)
    {
        _weatherService = weatherService;
    }

// Endpoint GET para buscar as informações do tempo para uma cidade
    [HttpGet("{city}")]
    public async Task<IActionResult> GetWeather(string city)
    {
        // Chama o serviço para obter as informações do tempo
        var weather = await _weatherService.GetWeatherAsync(city);
        if (weather == null)
        {
            return NotFound();
        }
        return Ok(weather);
    }
}
