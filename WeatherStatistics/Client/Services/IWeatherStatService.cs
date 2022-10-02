using WeatherStatistics.Shared;

namespace WeatherStatistics.Client.Services
{
    interface IWeatherStatService
    {
        Task<List<CityWStat>> GetAllCitiesStats();

        Task<CityWStat> GetCityWStatByUrl(string url);

    }
}
