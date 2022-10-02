using Microsoft.EntityFrameworkCore;
using WeatherStatistics.Shared;

namespace WeatherStatistics.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<CityWStat> CityWStats { get; set; }
    }
}
