using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsuTask.Migrations
{
    public partial class Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("18be4a4e-01d4-4edb-8038-b74d2a63f87d"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("3c50870c-5e4c-4826-a1be-3b8c53c70066"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("72fa84cf-6a30-4e1b-b15f-deb91b52e068"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("965c12e4-496e-49e2-95d3-009d03be064e"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("a85fee86-498e-4b4a-97f8-bab9ca414f4b"));

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Login = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorName", "Genre", "Name" },
                values: new object[] { new Guid("1732ab9c-ac13-49d6-86a0-f702095c3631"), "Ag", "Bdd", "Gg4" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorName", "Genre", "Name" },
                values: new object[] { new Guid("34be676d-256c-4471-ae01-5683c280678b"), "A", "B", "Gg" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorName", "Genre", "Name" },
                values: new object[] { new Guid("89021ba1-210a-48ea-9019-99f9d7866513"), "A1", "Bd2", "hhh2" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorName", "Genre", "Name" },
                values: new object[] { new Guid("af5cf798-7855-448e-add3-d4b9857319f5"), "Ads", "Bxx", "Gg77" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorName", "Genre", "Name" },
                values: new object[] { new Guid("ebf4194e-89f8-4cb4-a6ae-c0f7aa7a4150"), "Ab", "Bd", "Gg1" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Login", "Password" },
                values: new object[] { new Guid("a4d4058e-f67a-4901-9c17-19453c61a41e"), "test@gmail.com", "111111" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("1732ab9c-ac13-49d6-86a0-f702095c3631"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("34be676d-256c-4471-ae01-5683c280678b"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("89021ba1-210a-48ea-9019-99f9d7866513"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("af5cf798-7855-448e-add3-d4b9857319f5"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("ebf4194e-89f8-4cb4-a6ae-c0f7aa7a4150"));

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorName", "Genre", "Name" },
                values: new object[] { new Guid("18be4a4e-01d4-4edb-8038-b74d2a63f87d"), "A1", "Bd2", "hhh2" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorName", "Genre", "Name" },
                values: new object[] { new Guid("3c50870c-5e4c-4826-a1be-3b8c53c70066"), "Ag", "Bdd", "Gg4" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorName", "Genre", "Name" },
                values: new object[] { new Guid("72fa84cf-6a30-4e1b-b15f-deb91b52e068"), "A", "B", "Gg" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorName", "Genre", "Name" },
                values: new object[] { new Guid("965c12e4-496e-49e2-95d3-009d03be064e"), "Ads", "Bxx", "Gg77" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorName", "Genre", "Name" },
                values: new object[] { new Guid("a85fee86-498e-4b4a-97f8-bab9ca414f4b"), "Ab", "Bd", "Gg1" });
        }
    }
}
