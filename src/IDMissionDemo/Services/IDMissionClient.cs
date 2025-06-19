using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

public class IDMissionClient
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<IDMissionClient> _logger;
    private readonly IConfiguration _configuration;

    public IDMissionClient(HttpClient httpClient, ILogger<IDMissionClient> logger, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _logger = logger;
        _configuration = configuration;
    }

    public async Task<string> VerifyKycAsync(string documentImageBase64)
    {
        var url = _configuration["IDMission:Endpoint"] ?? throw new InvalidOperationException("Endpoint not configured");
        var apiKey = _configuration["IDMission:ApiKey"] ?? throw new InvalidOperationException("ApiKey not configured");
        var secret = _configuration["IDMission:Secret"] ?? throw new InvalidOperationException("Secret not configured");

        var payload = new
        {
            image = documentImageBase64,
            key = apiKey,
            secret = secret
        };

        var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(url, content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}
