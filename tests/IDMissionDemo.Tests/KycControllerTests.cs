using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

public class KycControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public KycControllerTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task Post_WithoutImage_ReturnsBadRequest()
    {
        var client = _factory.CreateClient();
        var response = await client.PostAsJsonAsync("/api/kyc", new { imageBase64 = "" });
        Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
    }
}
