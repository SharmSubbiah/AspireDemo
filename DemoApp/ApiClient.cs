
using AspireApi;

namespace AspireApp
{
    public class ApiClient
    {
        private HttpClient httpClient;
        public ApiClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<WeatherForecast[]> GetWeatherForecasts()
        {
            return await httpClient.GetFromJsonAsync<WeatherForecast[]>("weatherforecast");
        }
    }
}
