using WeatherStatistics.Shared;

namespace WeatherStatistics.Client.Services
{
    interface IWeatherStatService
    {
        List<CityWStat> GetAllCitiesStats();

        CityWStat GetCityWStatByUrl(string url);

    }
}
