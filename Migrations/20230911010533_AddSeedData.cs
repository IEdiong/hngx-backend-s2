using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hngXStageTwo.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "PhoneNumber",
                table: "Users",
                type: "bigint",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Birthdate", "CreatedTime", "Email", "FirstName", "LastName", "PhoneNumber", "UpdatedTime" },
                values: new object[] { 1, "123 Main St, Anytown, CA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1963), new DateTime(2023, 9, 11, 2, 5, 33, 587, DateTimeKind.Local).AddTicks(7540), "john.doe@yahoo.com", "John", "Doe", 2345586752L, new DateTime(2023, 9, 11, 2, 5, 33, 587, DateTimeKind.Local).AddTicks(7560) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 15);
        }
    }
}
