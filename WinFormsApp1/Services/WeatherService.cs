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
    public class WeatherService
    {

        public async static Task<dynamic> GetWeather()
        {
            HttpClient client = new HttpClient();
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SharedData.API_KEY);
            var response = await client.GetFromJsonAsync<object>($"{SharedData.API_URL}?key={SharedData.API_KEY}&q=15.783471");
            //response.EnsureSuccessStatusCode();
            //var jsonContent = await response.Content.ReadAsStringAsync();
            //var parsedJsonContent = await JsonSerializer.DeserializeAsync(jsonContent, typeof WeatherItem);
            //return "";

            Debug.WriteLine( response );
            return response;
        }
    }
}
