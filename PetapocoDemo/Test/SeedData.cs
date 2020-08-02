using PetapocoDemo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetapocoDemo.Model;

namespace PetapocoDemo.Test
{
    public class SeedData
    {
        public static async Task Initialize()
        {
            var rng = new Random();
            var repository = new CustomRepository();
            var items = await repository.SelectAllData<WeatherForecast>();
            if (items.Any())
            {
                return;
            }
            Array values = Enum.GetValues(typeof(WeatherSummary));
            for (int i = 0; i < 5; i++)
            {
                var item = new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(i),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = (WeatherSummary)values.GetValue(rng.Next(values.Length))
                };
                await repository.AddData(item);
            }
 
        }
    }
}
