namespace webhooks_demo;

public enum WebhookEvent
{
    /// <summary>
    /// Conversation `Summary` was updated
    /// </summary>
    ConversationSummaryUpdated,

    /// <summary>
    /// Conversation has been processed and is now `State = Success`
    /// </summary>
    ConversationProcessed
}