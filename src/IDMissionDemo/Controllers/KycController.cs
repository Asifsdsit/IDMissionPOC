using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class KycController : ControllerBase
{
    private readonly IDMissionClient _client;

    public KycController(IDMissionClient client)
    {
        _client = client;
    }

    [HttpPost]
    public async Task<IActionResult> Verify([FromBody] KycRequest request)
    {
        if (string.IsNullOrEmpty(request.ImageBase64))
        {
            return BadRequest("Image is required");
        }

        var result = await _client.VerifyKycAsync(request.ImageBase64);
        return Ok(result);
    }
}

public class KycRequest
{
    public string ImageBase64 { get; set; } = string.Empty;
}
