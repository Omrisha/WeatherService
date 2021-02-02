using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherService.Boundaries
{
    [Serializable]
    public class WeatherDetails
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Icon = {Icon}\n Description = {Description}";
        }
    }
}
