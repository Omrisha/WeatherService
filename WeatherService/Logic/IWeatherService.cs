using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherService.Boundaries;

namespace WeatherService.Logic
{
    public interface IWeatherService
    {
        Task<WeatherBoundary> GetWeather(string cityName);
        Task<IEnumerable<WeatherBoundary>> GetWeathers(string[] cities);
    }
}
