namespace webhooks_demo.Models;

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