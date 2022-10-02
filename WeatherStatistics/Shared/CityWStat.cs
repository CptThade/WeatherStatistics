namespace WeatherStatistics.Shared
{
    public enum CityStatus
    {
        ACTUAL,
        REMOVED,
        CREATED
    }
    public class CityWStat
    {
        public int Id { get; set; }
        public string? Url { get; set; }
        public string? Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public CityStatus CStatus { get; set; }
        public string? TimeStamp { get; set; } = DateTime.Now.ToString();
        public int CurTemperature { get; set; }
        public int MinTemperature { get; set; }
        public int MaxTemperature { get; set; }
        public int AvgTemperature { get; set; }

    }
}
