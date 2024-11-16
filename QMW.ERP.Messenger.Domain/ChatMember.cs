namespace QMW.ERP.Messenger.Domain;

public class ChatMember
{
    public long ChatId { get; set; }
    public Chat Chat { get; set; } = new();
    public long UserId { get; set; }
    public ChatUser User { get; set; } = new();
}