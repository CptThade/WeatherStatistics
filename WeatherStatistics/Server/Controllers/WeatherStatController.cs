using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherStatistics.Server.Data;
using WeatherStatistics.Shared;

namespace WeatherStatistics.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherStatController : ControllerBase
    {
        private readonly DataContext _context;

        public WeatherStatController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<CityWStat>> GetAllCitiesStats()
        {
            return Ok(_context.CityWStats);
        }

        [HttpGet("{url}")]
        public ActionResult<CityWStat> GetCityWStatByUrl(string url)
        {
            var city = _context.CityWStats.FirstOrDefault(c => c.Url.ToLower().Equals(url.ToLower()));
            if(city == null) return NotFound("City doesn't exist.");
            return Ok(city);
        }
    }
}
