using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.NET6.Data.Migrations
{
    public partial class AddedPeriodToLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46988784-f0cd-495f-bd13-206591117952",
                column: "ConcurrencyStamp",
                value: "5e8f0000-bb78-4ad8-bca2-85fe8edcf1f2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59425203-a9bb-495f-cc10-589390141783",
                column: "ConcurrencyStamp",
                value: "e066bb38-b3f8-434a-88c5-85b59be33699");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "144e6a24-bd97-4459-9296-0f480a11d0c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12230ab3-b4a1-4299-bb29-a712b1df2c32", "AQAAAAEAACcQAAAAEPfR+q5GuGbp50E5v0iO0p2wGYiC6cfOnJyrc1QFqMRjbsGyypmGmeXqXceXAeh4IQ==", "5396451f-d75c-405c-b34b-6f17f499aaa2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76966784-f8cd-495f-bd12-206590117953",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7d25aba-4cbb-4d14-92a8-2393c952ea6d", "AQAAAAEAACcQAAAAEA0ArK/J4QkpaOEdosEWVkY4i2O0EkIVM6IHHgUUA9Uq9hn/8eSU5WbwjExoObIYeg==", "6e5fd096-15c0-4811-b5a3-1f97a08ed95f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46988784-f0cd-495f-bd13-206591117952",
                column: "ConcurrencyStamp",
                value: "703b153a-a796-467e-966e-4608642a4abd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59425203-a9bb-495f-cc10-589390141783",
                column: "ConcurrencyStamp",
                value: "e8a2928f-9691-48b9-8d20-4d9f7748b786");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "144e6a24-bd97-4459-9296-0f480a11d0c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d87f40d1-926e-4ba0-8afe-b2022536f7e0", "AQAAAAEAACcQAAAAEP04naPW68U9ZTqXAkdyq0zVInmUELymZ7U/bDuz+NeXncKH0jYVPxwjbzcmfR+Log==", "ed6bcd7d-8425-4a61-9bff-86e2fe827127" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76966784-f8cd-495f-bd12-206590117953",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "742161cc-3d9a-41ab-9f09-675ffa2e01f9", "AQAAAAEAACcQAAAAEJnl7xfqJXWaLIyYWRuMXvdHu5lWLoF69+XSqfYVv9JvXvTdUAJcJkU51wXtHdaCsw==", "afad4918-fd8f-4015-b4b9-3df878bdb63f" });
        }
    }
}
