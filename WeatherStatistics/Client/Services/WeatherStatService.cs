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
            return await _http.GetFromJsonAsync<List<CityWStat>>("api/WeatherStat");
        }

        public async Task<CityWStat> GetCityWStatByUrl(string url)
        {
            var city_stat = await _http.GetFromJsonAsync<CityWStat>($"api/WeatherStat/{url}");
            return city_stat;
        }
    }
}
