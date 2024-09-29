using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Author 1" },
                    { 2, "Author 2" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Created", "Due" },
                values: new object[] { 1, new DateTime(2024, 9, 28, 21, 51, 35, 778, DateTimeKind.Local).AddTicks(3018), new DateTime(2024, 10, 3, 21, 51, 35, 778, DateTimeKind.Local).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Created", "Due" },
                values: new object[] { 1, new DateTime(2024, 9, 28, 21, 51, 35, 778, DateTimeKind.Local).AddTicks(3060), new DateTime(2024, 10, 3, 21, 51, 35, 778, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 3, 2, new DateTime(2024, 9, 28, 21, 51, 35, 778, DateTimeKind.Local).AddTicks(3066), "Dis C", new DateTime(2024, 10, 3, 21, 51, 35, 778, DateTimeKind.Local).AddTicks(3067), 0, "Title C" });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 9, 28, 20, 32, 43, 742, DateTimeKind.Local).AddTicks(7605), new DateTime(2024, 10, 3, 20, 32, 43, 742, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 9, 28, 20, 32, 43, 742, DateTimeKind.Local).AddTicks(7637), new DateTime(2024, 10, 3, 20, 32, 43, 742, DateTimeKind.Local).AddTicks(7638) });
        }
    }
}
