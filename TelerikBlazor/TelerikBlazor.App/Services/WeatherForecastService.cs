using System;
using System.Linq;
using System.Threading.Tasks;

namespace TelerikBlazor.App.Services
{
    public class WeatherForecastService
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 20).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                TemperatureF = rng.Next(-20, 55) * 9 / 5 + 32,
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
