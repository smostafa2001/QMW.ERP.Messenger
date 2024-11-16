using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMW.ERP.Messenger.Application.Chats;
public class ChatDTO
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Avatar { get; set; }
    public long SenderId { get; set; }
    public long ReceiverId { get; set; }
}
