using WebApplication2.Services;

public interface IWeatherForecastService
{
     IEnumerable<WeatherForecast> GetForecasts();
}