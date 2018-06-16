using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPlayground.Services
{
    public class WeatherService
    {
        public Task<IEnumerable<WeatherData>> GetWeatherAsync()
        {
            return Task.FromResult<IEnumerable<WeatherData>>(new List<WeatherData>
            {
                new WeatherData
                {
                    Date= DateTime.Parse("2018-05-06"),
                    TemperatureC= 1,
                    Summary= "Freezing",
                    TemperatureF= 33
                },
                new WeatherData
                {
                    Date=  DateTime.Parse("2018-05-07"),
                    TemperatureC= 14,
                    Summary= "Bracing",
                    TemperatureF= 57
                },
                new WeatherData
                {
                    Date= DateTime.Parse( "2018-05-08"),
                    TemperatureC= -13,
                    Summary= "Freezing",
                    TemperatureF= 9
                },
                new WeatherData
                {
                    Date=  DateTime.Parse("2018-05-09"),
                    TemperatureC= -16,
                    Summary= "Balmy",
                    TemperatureF= 4
                },
                new WeatherData
                {
                    Date=  DateTime.Parse("2018-05-10"),
                    TemperatureC= -2,
                    Summary= "Chilly",
                    TemperatureF= 29
                }
            });
        }
    }

    public class WeatherData
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }
        public int TemperatureF { get; set; }
    }
}
