using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherService.Boundaries;
using WeatherService.Logic;

namespace WeatherService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        private readonly ILogger<WeatherController> _logger;

        public WeatherController(ILogger<WeatherController> logger, IWeatherService weatherService)
        {
            _logger = logger;
            _weatherService = weatherService;
        }

        [HttpGet("{cityName}")]
        public Task<WeatherBoundary> Get(string cityName)
        {
            return _weatherService.GetWeather(cityName);
        }

        [HttpGet()]
        public Task<IEnumerable<WeatherBoundary>> GetWeathers([FromQuery] string[] cities)
        {
            return _weatherService.GetWeathers(cities);
        }
    }
}
