using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SyncSyntax.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Technology", null },
                    { 2, "Health", null },
                    { 3, "LifeStyle", null }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "CategoryId", "Content", "FeaturedImageUrl", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 1, "Hamid Idrees", 1, "This is a beginner guide to .NET development.", "https://example.com/images/dotnet.png", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to .NET" },
                    { 2, "Fahad Ali", 2, "Simple habits for a healthier lifestyle.", "https://example.com/images/health.png", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthy Living Tips" },
                    { 3, "Alex Carry", 3, "How to maintain productivity without burnout.", "https://example.com/images/lifestyle.png", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work-Life Balance" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
