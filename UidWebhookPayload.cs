namespace webhooks_demo;

public record UidWebhookPayload : WebhookPayload
{
    /// <summary>
    /// Unique identity of entity which caused the webhook event
    /// </summary>
    public required Guid Uid { get; init; }
}