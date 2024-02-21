using webhooks_demo;

public record FullWebhookPayload<T> : WebhookPayload
{
    /// <summary>
    /// Full entity which caused the webhook event
    /// </summary>
    public required T Entity { get; init; }
}