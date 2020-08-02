using System;
using PetaPoco;

namespace PetapocoDemo.Model
{
    public class WeatherForecast
    {
        public int id { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        [ResultColumn]
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public WeatherSummary Summary { get; set; }
    }
}
