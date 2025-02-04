using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS_API.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmittedAt",
                value: new DateTime(2024, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubmittedAt",
                value: new DateTime(2024, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StaticPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 4, 5, 50, 7, 58, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "StaticPage",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 4, 5, 50, 7, 58, DateTimeKind.Utc).AddTicks(1414));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 4, 5, 47, 35, 623, DateTimeKind.Utc).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 4, 5, 47, 35, 623, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmittedAt",
                value: new DateTime(2025, 2, 4, 5, 47, 35, 623, DateTimeKind.Utc).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubmittedAt",
                value: new DateTime(2025, 2, 4, 5, 47, 35, 623, DateTimeKind.Utc).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "StaticPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 4, 5, 47, 35, 622, DateTimeKind.Utc).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "StaticPage",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 4, 5, 47, 35, 622, DateTimeKind.Utc).AddTicks(1284));
        }
    }
}
