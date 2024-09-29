using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description", "Due", "Status", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 28, 20, 32, 43, 742, DateTimeKind.Local).AddTicks(7605), "Dis A", new DateTime(2024, 10, 3, 20, 32, 43, 742, DateTimeKind.Local).AddTicks(7627), 0, "Title A" },
                    { 2, new DateTime(2024, 9, 28, 20, 32, 43, 742, DateTimeKind.Local).AddTicks(7637), "Dis B", new DateTime(2024, 10, 3, 20, 32, 43, 742, DateTimeKind.Local).AddTicks(7638), 0, "Title B" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
