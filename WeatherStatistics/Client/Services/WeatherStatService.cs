using System;
using System.Net.Http.Json;
using WeatherStatistics.Shared;

namespace WeatherStatistics.Client.Services
{
    public class WeatherStatService : IWeatherStatService
    {
        private readonly HttpClient _http;

        public WeatherStatService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<CityWStat>> GetAllCitiesStats()
        {
            var result = await _http.GetAsync($"api/WeatherStat");
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                var message = result.Content.ReadAsStringAsync();
                Console.WriteLine(message);
                return new List<CityWStat> () { new CityWStat() { Name = message.ToString()} };
            }
            else
            {
                return await _http.GetFromJsonAsync<List<CityWStat>>("api/WeatherStat");
            }
        }

        public async Task<CityWStat> GetCityWStatByUrl(string url)
        {
            //var city_stat = await _http.GetFromJsonAsync<CityWStat>($"api/WeatherStat/{url}");
            //return city_stat;

            var result = await _http.GetAsync($"api/WeatherStat/{url}");
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                var message = result.Content.ReadAsStringAsync();
                Console.WriteLine(message);
                return new CityWStat { Name = message.ToString() };
            }
            else
            {
                return await result.Content.ReadFromJsonAsync<CityWStat>();
            }
        }
    }
}
