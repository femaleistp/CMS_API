using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedFixedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "StaticPage",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Feedback",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "BlogPost",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "550e8400-e29b-41d4-a716-446655440000", 0, "8c53efe6-37c7-43d7-848b-923a54308539", "testuser@example.com", true, false, null, "TESTUSER@EXAMPLE.COM", "TESTUSER", "AQAAAAIAAYagAAAAEKHThnbUeYENSY2U8OdspULiPBnFIvVj48qYTeaf3qUZjxHW50fhklpE3g6bEx0ncA==", null, false, "550e8400-e29b-41d4-a716-446655440001", false, "testuser" });

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "550e8400-e29b-41d4-a716-446655440000");

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "550e8400-e29b-41d4-a716-446655440000");

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "550e8400-e29b-41d4-a716-446655440000");

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "550e8400-e29b-41d4-a716-446655440000");

            migrationBuilder.UpdateData(
                table: "StaticPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "550e8400-e29b-41d4-a716-446655440000");

            migrationBuilder.UpdateData(
                table: "StaticPage",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "550e8400-e29b-41d4-a716-446655440000");

            migrationBuilder.CreateIndex(
                name: "IX_StaticPage_UserId",
                table: "StaticPage",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_UserId",
                table: "Feedback",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPost_UserId",
                table: "BlogPost",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPost_AspNetUsers_UserId",
                table: "BlogPost",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_AspNetUsers_UserId",
                table: "Feedback",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StaticPage_AspNetUsers_UserId",
                table: "StaticPage",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPost_AspNetUsers_UserId",
                table: "BlogPost");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_AspNetUsers_UserId",
                table: "Feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_StaticPage_AspNetUsers_UserId",
                table: "StaticPage");

            migrationBuilder.DropIndex(
                name: "IX_StaticPage_UserId",
                table: "StaticPage");

            migrationBuilder.DropIndex(
                name: "IX_Feedback_UserId",
                table: "Feedback");

            migrationBuilder.DropIndex(
                name: "IX_BlogPost_UserId",
                table: "BlogPost");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "550e8400-e29b-41d4-a716-446655440000");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "StaticPage");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Feedback");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BlogPost");
        }
    }
}
