namespace webhooks_demo;

public abstract record WebhookPayload
{
    /// <summary>
    /// Unique identity of webhook event
    /// </summary>
    public Guid EventUid { get; init; }

    /// <summary>
    /// Event which triggered webhook
    /// </summary>
    public required WebhookEvent Event { get; init; }
}