namespace QMW.ERP.Messenger.Domain;
public class Chat
{
    public long Id { get; set; }
    public ICollection<ChatMember> Members { get; set; } = [];
    public ICollection<Message> Messages { get; set; } = [];
    public string? Name { get; set; } = string.Empty;
    public string? Avatar { get; set; }
    public long? OwnerId { get; set; }
    public ChatUser? Owner { get; set; } = new();
    public ChatDiscriminator Discriminator { get; set; }
}