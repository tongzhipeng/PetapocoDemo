using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetapocoDemo.Model;
using PetapocoDemo.Repository;

namespace PetapocoDemo.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly ICustomRepository _repository;
        public WeatherService(ICustomRepository repository)
        {
            _repository = repository;
        }
        public async Task<WeatherForecast> AddWeatherForecast(WeatherForecast weatherForecast)
        {
            return (WeatherForecast)await _repository.AddData(weatherForecast);
        }

        public async Task<int> DeleteWeatherForecastById(int id)
        {
            return await _repository.DeleteById<WeatherForecast>(id); 
        }

        public async Task<WeatherForecast> FindWeatherForecastById(int id)
        {
            return await _repository.SelectById<WeatherForecast>(id);
        }

        public async Task<List<WeatherForecast>> GetAllWeatherForecast()
        {
            return await _repository.SelectAllData<WeatherForecast>();
        }

        public async Task<int> UpdateWeatherForecast(WeatherForecast weatherForecast)
        {
            return await _repository.UpdateData<WeatherForecast>(weatherForecast, weatherForecast.id);
        }
    }
}
