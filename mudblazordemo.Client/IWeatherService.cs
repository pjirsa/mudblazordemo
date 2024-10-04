using mudblazordemo.Client.Models;

namespace mudblazordemo.Client;

public interface IWeatherService
{
    Task<WeatherForecast[]> GetWeather();
}