using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetapocoDemo.Model;

namespace PetapocoDemo.Services
{
    public interface IWeatherService
    {
        public Task<List<WeatherForecast>> GetAllWeatherForecast();
        public Task<WeatherForecast> FindWeatherForecastById(int id);
        public Task<int> DeleteWeatherForecastById(int id);
        public Task<WeatherForecast> AddWeatherForecast(WeatherForecast weatherForecast);
        public Task<int> UpdateWeatherForecast(WeatherForecast weatherForecast);
    }
}
