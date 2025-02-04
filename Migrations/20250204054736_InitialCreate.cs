using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CMS_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogPost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessContact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessContact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubmittedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaticPage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaticPage", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BlogPost",
                columns: new[] { "Id", "Content", "CreatedAt", "Title" },
                values: new object[,]
                {
                    { 1, "This is a sample blog post.", new DateTime(2025, 2, 4, 5, 47, 35, 623, DateTimeKind.Utc).AddTicks(1868), "First Blog Post" },
                    { 2, "Another post for testing.", new DateTime(2025, 2, 4, 5, 47, 35, 623, DateTimeKind.Utc).AddTicks(2090), "Second Blog Post" }
                });

            migrationBuilder.InsertData(
                table: "BusinessContact",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "john@example.com", "John Doe", "123-456-7890" },
                    { 2, "jane@example.com", "Jane Smith", "987-654-3210" }
                });

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "Id", "Email", "Message", "Name", "SubmittedAt" },
                values: new object[,]
                {
                    { 1, "alice@example.com", "Great website!", "Alice", new DateTime(2025, 2, 4, 5, 47, 35, 623, DateTimeKind.Utc).AddTicks(4925) },
                    { 2, "bob@example.com", "Needs improvement.", "Bob", new DateTime(2025, 2, 4, 5, 47, 35, 623, DateTimeKind.Utc).AddTicks(5116) }
                });

            migrationBuilder.InsertData(
                table: "StaticPage",
                columns: new[] { "Id", "Content", "CreatedAt", "Title" },
                values: new object[,]
                {
                    { 1, "Welcome to our site!", new DateTime(2025, 2, 4, 5, 47, 35, 622, DateTimeKind.Utc).AddTicks(1129), "Home" },
                    { 2, "About us page content.", new DateTime(2025, 2, 4, 5, 47, 35, 622, DateTimeKind.Utc).AddTicks(1284), "About" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPost");

            migrationBuilder.DropTable(
                name: "BusinessContact");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "StaticPage");
        }
    }
}
