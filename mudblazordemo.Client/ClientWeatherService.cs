using mudblazordemo.Client.Models;
using System.Net.Http.Json;

namespace mudblazordemo.Client;

public class ClientWeatherService(HttpClient httpClient) : IWeatherService
{
    public Task<WeatherForecast[]> GetWeather() => 
        httpClient.GetFromJsonAsync<WeatherForecast[]>("api/weather")!;
}
