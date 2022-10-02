using WeatherStatistics.Shared;

namespace WeatherStatistics.Client.Services
{
    public class WeatherStatService : IWeatherStatService
    {

        public List<CityWStat> CityStats { get; set; } = new List<CityWStat>
        {
            new CityWStat {Url = "first-city", Name = "Moscow", Latitude = 55.752, Longitude = 37.616,
            CStatus = CityStatus.CREATED,
            MinTemperature = -40, MaxTemperature = 32, AvgTemperature = 3}
        };
        public List<CityWStat> GetAllCitiesStats()
        {
            return CityStats;
        }

        public CityWStat GetCityWStatByUrl(string url)
        {
            return CityStats.FirstOrDefault(c => c.Url.ToLower().Equals(url.ToLower()));
        }
    }
}
