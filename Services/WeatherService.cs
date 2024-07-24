using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AppMauiClima.Models;

namespace AppMauiClima.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://api.pirateweather.net/forecast/moICXzP3PS04Poq64YUyghGgxTDxuxEy/";

        public WeatherService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<WeatherData> GetWeatherDataAsync(string latitude, string longitude)
        {
            try
            {
                var url = $"{BaseUrl}{latitude},{longitude}";
                var response = await _httpClient.GetStringAsync(url);
                return JsonConvert.DeserializeObject<WeatherData>(response);
            }
            catch (HttpRequestException httpEx)
            {
                // Log de error específico de HttpRequest
                Console.WriteLine($"HTTP Request Error: {httpEx.Message}");
                throw;
            }
            catch (Exception ex)
            {
                // Log de otros errores
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
    }
}
