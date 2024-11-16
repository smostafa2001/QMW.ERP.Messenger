namespace QMW.ERP.Messenger.Domain;

public class ContactLink
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public long ContactId { get; set; }
    public ChatUser Contact { get; set; } = new();
    public long LinkId { get; set; }
    public ChatUser Link { get; set; } = new();
}