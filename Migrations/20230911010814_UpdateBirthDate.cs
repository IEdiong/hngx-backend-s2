using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hngXStageTwo.Migrations
{
    public partial class UpdateBirthDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthdate", "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(1985, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 11, 2, 8, 14, 76, DateTimeKind.Local).AddTicks(8190), new DateTime(2023, 9, 11, 2, 8, 14, 76, DateTimeKind.Local).AddTicks(8210) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthdate", "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1963), new DateTime(2023, 9, 11, 2, 5, 33, 587, DateTimeKind.Local).AddTicks(7540), new DateTime(2023, 9, 11, 2, 5, 33, 587, DateTimeKind.Local).AddTicks(7560) });
        }
    }
}
