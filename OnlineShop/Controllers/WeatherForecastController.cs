using Microsoft.AspNetCore.Mvc;
using OnlineShop.Services;

namespace OnlineShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly WeatherForecastService _service;
        //private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController( WeatherForecastService service)
        {
            //_logger = logger;
            _service = service;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _service.GetWeather();

        }
    }
}