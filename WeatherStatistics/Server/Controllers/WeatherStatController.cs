using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherStatistics.Shared;

namespace WeatherStatistics.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherStatController : ControllerBase
    {
        public List<CityWStat> CityStats { get; set; } = new List<CityWStat>
        {
            new CityWStat {Url = "first-city", Name = "Moscow", Latitude = 55.752, Longitude = 37.616,
            CStatus = CityStatus.CREATED,
            MinTemperature = -40, MaxTemperature = 32, AvgTemperature = 3}
        };

        [HttpGet]
        public ActionResult<List<CityWStat>> GetAllCitiesStats()
        {
            return Ok(CityStats);
        }

        [HttpGet("{url}")]
        public ActionResult<CityWStat> GetCityWStatByUrl(string url)
        {
            var city = CityStats.FirstOrDefault(c => c.Url.ToLower().Equals(url.ToLower()));
            if(city == null) return NotFound("City doesn't exist.");
            return Ok(city);
        }
    }
}
