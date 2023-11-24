using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Net.Http.Json;
using System.Diagnostics;

namespace AviaApp.Services
{
    public class WeatherData
    {
        public CurrentWeatherData Current { get; set; }
    }

    public class CurrentWeatherData
    {
        public float TempC { get; set; }
        public float TempF { get; set; }
        public ConditionData Condition { get; set; }
        public float PrecipMm { get; set; }
        public float PrecipIn { get; set; }
    }

    public class ConditionData
    {
        public string Text { get; set; }
        public int Code { get; set; }
    }

    public class WeatherService
    {   

        public async static Task<WeatherData> GetWeather(DateTime date, string cityName)
        {
            try
            {
                HttpClient client = new HttpClient();
                var response = await client.GetFromJsonAsync<WeatherData>($"{SharedData.API_URL}?key={SharedData.API_KEY}&q={cityName}&dt={date}&days=1");
                return response;
            } catch(Exception err)
            {
                Debug.WriteLine(err.Message);
                return new WeatherData { };
            }
        }
    }
}
