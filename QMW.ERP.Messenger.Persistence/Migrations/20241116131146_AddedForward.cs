using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QMW.ERP.Messenger.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedForward : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatMember_AspNetUsers_UserId",
                table: "ChatMember");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatMember_Chat_ChatId",
                table: "ChatMember");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactLink_AspNetUsers_ContactId",
                table: "ContactLink");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactLink_AspNetUsers_LinkId",
                table: "ContactLink");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_AspNetUsers_SenderId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_Chat_ChatId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_Message_RepliedMessageId",
                table: "Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message",
                table: "Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactLink",
                table: "ContactLink");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChatMember",
                table: "ChatMember");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chat",
                table: "Chat");

            migrationBuilder.DropColumn(
                name: "IsForwarded",
                table: "Message");

            migrationBuilder.RenameTable(
                name: "Message",
                newName: "Messages");

            migrationBuilder.RenameTable(
                name: "ContactLink",
                newName: "ContactLinks");

            migrationBuilder.RenameTable(
                name: "ChatMember",
                newName: "ChatMembers");

            migrationBuilder.RenameTable(
                name: "Chat",
                newName: "Chats");

            migrationBuilder.RenameIndex(
                name: "IX_Message_SenderId",
                table: "Messages",
                newName: "IX_Messages_SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Message_RepliedMessageId",
                table: "Messages",
                newName: "IX_Messages_RepliedMessageId");

            migrationBuilder.RenameIndex(
                name: "IX_Message_ChatId",
                table: "Messages",
                newName: "IX_Messages_ChatId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactLink_ContactId",
                table: "ContactLinks",
                newName: "IX_ContactLinks_ContactId");

            migrationBuilder.RenameIndex(
                name: "IX_ChatMember_UserId",
                table: "ChatMembers",
                newName: "IX_ChatMembers_UserId");

            migrationBuilder.AddColumn<long>(
                name: "SourceChatId",
                table: "Messages",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactLinks",
                table: "ContactLinks",
                columns: new[] { "LinkId", "ContactId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChatMembers",
                table: "ChatMembers",
                columns: new[] { "ChatId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chats",
                table: "Chats",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SourceChatId",
                table: "Messages",
                column: "SourceChatId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMembers_AspNetUsers_UserId",
                table: "ChatMembers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMembers_Chats_ChatId",
                table: "ChatMembers",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactLinks_AspNetUsers_ContactId",
                table: "ContactLinks",
                column: "ContactId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactLinks_AspNetUsers_LinkId",
                table: "ContactLinks",
                column: "LinkId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_SenderId",
                table: "Messages",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Chats_SourceChatId",
                table: "Messages",
                column: "SourceChatId",
                principalTable: "Chats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Messages_RepliedMessageId",
                table: "Messages",
                column: "RepliedMessageId",
                principalTable: "Messages",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatMembers_AspNetUsers_UserId",
                table: "ChatMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatMembers_Chats_ChatId",
                table: "ChatMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactLinks_AspNetUsers_ContactId",
                table: "ContactLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactLinks_AspNetUsers_LinkId",
                table: "ContactLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_SenderId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Chats_SourceChatId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Messages_RepliedMessageId",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_SourceChatId",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactLinks",
                table: "ContactLinks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chats",
                table: "Chats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChatMembers",
                table: "ChatMembers");

            migrationBuilder.DropColumn(
                name: "SourceChatId",
                table: "Messages");

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "Message");

            migrationBuilder.RenameTable(
                name: "ContactLinks",
                newName: "ContactLink");

            migrationBuilder.RenameTable(
                name: "Chats",
                newName: "Chat");

            migrationBuilder.RenameTable(
                name: "ChatMembers",
                newName: "ChatMember");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_SenderId",
                table: "Message",
                newName: "IX_Message_SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_RepliedMessageId",
                table: "Message",
                newName: "IX_Message_RepliedMessageId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_ChatId",
                table: "Message",
                newName: "IX_Message_ChatId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactLinks_ContactId",
                table: "ContactLink",
                newName: "IX_ContactLink_ContactId");

            migrationBuilder.RenameIndex(
                name: "IX_ChatMembers_UserId",
                table: "ChatMember",
                newName: "IX_ChatMember_UserId");

            migrationBuilder.AddColumn<bool>(
                name: "IsForwarded",
                table: "Message",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                table: "Message",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactLink",
                table: "ContactLink",
                columns: new[] { "LinkId", "ContactId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chat",
                table: "Chat",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChatMember",
                table: "ChatMember",
                columns: new[] { "ChatId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMember_AspNetUsers_UserId",
                table: "ChatMember",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMember_Chat_ChatId",
                table: "ChatMember",
                column: "ChatId",
                principalTable: "Chat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactLink_AspNetUsers_ContactId",
                table: "ContactLink",
                column: "ContactId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactLink_AspNetUsers_LinkId",
                table: "ContactLink",
                column: "LinkId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_AspNetUsers_SenderId",
                table: "Message",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Chat_ChatId",
                table: "Message",
                column: "ChatId",
                principalTable: "Chat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Message_RepliedMessageId",
                table: "Message",
                column: "RepliedMessageId",
                principalTable: "Message",
                principalColumn: "Id");
        }
    }
}
