using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherService.Boundaries
{
    [Serializable]
    public class WeatherBoundary
    {
        [JsonProperty("city_name")]
        public string CityName { get; set; }
        [JsonProperty("temp")]
        public double Temperature { get; set; }
        [JsonProperty("weather")]
        public WeatherDetails WeatherDescription { get; set; }
        [JsonProperty("sunset")]
        public string SunsetTime { get; set; }
        [JsonProperty("wind_dir")]
        public string WindDirection { get; set; }

        public override string ToString()
        {
            return $"CityName = {CityName}\n Temperature = {Temperature}\n WeatherDescription = {WeatherDescription}\n SunsetTime = {SunsetTime}\n WindDirection = {WindDirection}";
        }
    }
}
