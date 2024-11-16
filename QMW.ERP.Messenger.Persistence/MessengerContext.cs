using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QMW.ERP.Messenger.Domain;

namespace QMW.ERP.Messenger.Persistence;

public class MessengerContext(DbContextOptions options) : IdentityDbContext<ChatUser, IdentityRole<long>, long>(options)
{
    public DbSet<Chat> Chats { get; set; }
    public DbSet<ChatMember> ChatMembers { get; set; }
    public DbSet<ContactLink> ContactLinks { get; set; }
    public DbSet<Message> Messages { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Chat>()
            .HasMany(c => c.Messages)
            .WithOne(m => m.Chat)
            .HasForeignKey(m => m.ChatId);

        builder.Entity<Chat>()
            .HasMany(c => c.Members)
            .WithOne(cm => cm.Chat)
            .HasForeignKey(cm => cm.ChatId);

        builder.Entity<Chat>()
            .HasOne(c => c.Owner)
            .WithMany(cu => cu.OwnedGroupChats)
            .HasForeignKey(c => c.OwnerId);

        builder.Entity<ChatMember>().HasKey(cm => new { cm.ChatId, cm.UserId });

        builder.Entity<ChatMember>()
            .HasOne(cm => cm.Chat)
            .WithMany(c => c.Members)
            .HasForeignKey(cm => cm.ChatId);

        builder.Entity<ChatMember>()
            .HasOne(cm => cm.User)
            .WithMany(cu => cu.Chats)
            .HasForeignKey(cm => cm.UserId);

        builder.Entity<ChatUser>()
            .HasMany(cu => cu.Contacts)
            .WithOne(cl => cl.Link)
            .HasForeignKey(cl => cl.LinkId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<ChatUser>()
            .HasMany(cu => cu.Links)
            .WithOne(cl => cl.Contact)
            .HasForeignKey(cl => cl.ContactId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<ChatUser>()
            .HasMany(cu => cu.Chats)
            .WithOne(cm => cm.User)
            .HasForeignKey(cm => cm.UserId);

        builder.Entity<ChatUser>()
            .HasMany(cu => cu.Messages)
            .WithOne(cu => cu.Sender)
            .HasForeignKey(m => m.SenderId);

        builder.Entity<ContactLink>().HasKey(cl => new { cl.LinkId, cl.ContactId });

        builder.Entity<ContactLink>()
            .HasOne(cl => cl.Link)
            .WithMany(cu => cu.Contacts)
            .HasForeignKey(cl => cl.LinkId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<ContactLink>()
            .HasOne(cl => cl.Contact)
            .WithMany(cu => cu.Links)
            .HasForeignKey(cl => cl.ContactId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<Message>()
            .HasOne(m => m.Chat)
            .WithMany(c => c.Messages)
            .HasForeignKey(m => m.ChatId);

        builder.Entity<Message>()
            .HasOne(m => m.Sender)
            .WithMany(cu => cu.Messages)
            .HasForeignKey(m => m.SenderId);

        builder.Entity<Message>()
            .HasOne(m => m.RepliedMessage)
            .WithMany(m => m.Replies)
            .HasForeignKey(m => m.RepliedMessageId);

        builder.Entity<Message>()
            .HasMany(m => m.Replies)
            .WithOne(m => m.RepliedMessage)
            .HasForeignKey(m => m.RepliedMessageId);

        builder.Entity<Message>()
            .HasOne(m => m.SourceChat)
            .WithMany()
            .HasForeignKey(m => m.SourceChatId);
    }
}