using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsuTask.Migrations
{
    public partial class InsertBookData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
