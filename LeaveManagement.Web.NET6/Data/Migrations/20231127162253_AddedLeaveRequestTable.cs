using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.NET6.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46988784-f0cd-495f-bd13-206591117952",
                column: "ConcurrencyStamp",
                value: "82d706ac-7f8b-49d5-8c8a-714f3a59a5ad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59425203-a9bb-495f-cc10-589390141783",
                column: "ConcurrencyStamp",
                value: "a580cd32-982d-4bbd-9b6b-f8bfe05e4c13");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "144e6a24-bd97-4459-9296-0f480a11d0c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24eff092-11a2-4cd2-90a4-59dc54cebfb2", "AQAAAAEAACcQAAAAEGk7Hi+aMHkQccXqRgjn6TVrRwjDUkxcMe1/tWSllsGho3472Q8gAM/lo06py4qaAA==", "680292b0-ed38-4781-83c2-fa0fbffb8fff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76966784-f8cd-495f-bd12-206590117953",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1d49804-112f-4e78-84b7-9931302b130e", "AQAAAAEAACcQAAAAENBivk5+SRadKxPg7YZoG3hsCQN67r3XKWdQo9j/GNhcsgEhooXjNrvEjU34k4eNKQ==", "c04e2c9e-9962-4e50-b502-c5df485886fb" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
