using Microsoft.AspNetCore.Identity;

namespace QMW.ERP.Messenger.Domain;

public class ChatUser : IdentityUser<long>
{
    public string FirstName { get; set; } = string.Empty;
    public string? LastName { get; set; } = string.Empty;
    public string? Avatar { get; set; }
    public ICollection<ContactLink> Contacts { get; set; } = [];
    public ICollection<ContactLink> Links { get; set; } = [];
    public ICollection<ChatMember> Chats { get; set; } = [];
    public ICollection<Message> Messages { get; set; } = [];
    public ICollection<Chat> OwnedGroupChats { get; set; } = [];
}