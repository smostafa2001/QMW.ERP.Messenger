namespace QMW.ERP.Messenger.Domain;

public class Message
{
    public long Id { get; set; }
    public long ChatId { get; set; }
    public Chat Chat { get; set; } = new();
    public string? Content { get; set; }
    public DateTime Timestamp { get; set; }
    public long SenderId { get; set; }
    public ChatUser Sender { get; set; } = new();
    public long? RepliedMessageId { get; set; }
    public Message? RepliedMessage { get; set; }
    public ICollection<Message> Replies { get; set; } = [];
    public string? File { get; set; }
    public long? SourceChatId { get; set; }
    public Chat? SourceChat { get; set; }
    public bool IsSeen { get; set; }
}