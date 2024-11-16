using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QMW.ERP.Messenger.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedContactName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "ContactLinks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "ContactLinks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "ContactLinks");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "ContactLinks");
        }
    }
}
