using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.NET6.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "46988784-f0cd-495f-bd13-206591117952", "703b153a-a796-467e-966e-4608642a4abd", "Administrator", "ADMINISTRATOR" },
                    { "59425203-a9bb-495f-cc10-589390141783", "e8a2928f-9691-48b9-8d20-4d9f7748b786", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxID", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "144e6a24-bd97-4459-9296-0f480a11d0c3", 0, "d87f40d1-926e-4ba0-8afe-b2022536f7e0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AndewGarcia22@gmail.com", true, "Andew", "Garcia", false, null, "ANDEWGARCIA22@GMAIL.COM", "ANDEWGARCIA22@GMAIL.COM", "AQAAAAEAACcQAAAAEP04naPW68U9ZTqXAkdyq0zVInmUELymZ7U/bDuz+NeXncKH0jYVPxwjbzcmfR+Log==", null, false, "ed6bcd7d-8425-4a61-9bff-86e2fe827127", null, false, "AndewGarcia22@gmail.com" },
                    { "76966784-f8cd-495f-bd12-206590117953", 0, "742161cc-3d9a-41ab-9f09-675ffa2e01f9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "koshilolik@gmail.com", true, "Oleg", "Koshil", false, null, "KOSHILOLIK@GMAIL.COM", "KOSHILOLIK@GMAIL.COM", "AQAAAAEAACcQAAAAEJnl7xfqJXWaLIyYWRuMXvdHu5lWLoF69+XSqfYVv9JvXvTdUAJcJkU51wXtHdaCsw==", null, false, "afad4918-fd8f-4015-b4b9-3df878bdb63f", null, false, "koshilolik@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "59425203-a9bb-495f-cc10-589390141783", "144e6a24-bd97-4459-9296-0f480a11d0c3" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "46988784-f0cd-495f-bd13-206591117952", "76966784-f8cd-495f-bd12-206590117953" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "59425203-a9bb-495f-cc10-589390141783", "144e6a24-bd97-4459-9296-0f480a11d0c3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "46988784-f0cd-495f-bd13-206591117952", "76966784-f8cd-495f-bd12-206590117953" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46988784-f0cd-495f-bd13-206591117952");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59425203-a9bb-495f-cc10-589390141783");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "144e6a24-bd97-4459-9296-0f480a11d0c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76966784-f8cd-495f-bd12-206590117953");
        }
    }
}
