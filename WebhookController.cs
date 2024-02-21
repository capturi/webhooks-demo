using Microsoft.AspNetCore.Mvc;
using webhooks_demo.CapturiIntegrationClient;

namespace webhooks_demo;

[ApiController]
[Route("/conversation-processed")]
public class WebhookController(ILogger<WebhookController> logger) : Controller
{
    [HttpPost("uid")]
    public IActionResult Uid([FromBody] UidWebhookPayload payload)
    {
        logger.LogInformation("Conversation {Uid} processed", payload.Uid);
        return Ok();
    }

    [HttpPost("full")]
    public IActionResult Full([FromBody] FullWebhookPayload<IntegrationConversationView> payload)
    {
        logger.LogInformation("Conversation {Uid} processed", payload.Entity.Uid);
        return Ok();
    }
}