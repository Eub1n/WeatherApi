public class WeatherService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;

    public WeatherService(HttpClient httpClient, IConfiguration configuration)
    {
        // Inicializa o HttpClient passado como parâmetro
        _httpClient = httpClient;
        // Obtém a chave da API do OpenWeatherMap a partir da .env
        DotNetEnv.Env.Load();
        _apiKey = Environment.GetEnvironmentVariable("API_KEY");
    }

    public async Task<WeatherResponse> GetWeatherAsync(string city)
    {
        // Faz uma requisição GET à API do OpenWeatherMap e deserializa a resposta para o tipo WeatherResponse
        var response = await _httpClient.GetFromJsonAsync<WeatherResponse>(
            $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric");

        return response;
    }
}
