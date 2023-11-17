using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ffffe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 11, 9, 24, 44, 57, DateTimeKind.Local).AddTicks(493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 11, 11, 9, 21, 42, 216, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 11, 9, 24, 44, 57, DateTimeKind.Local).AddTicks(2884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 11, 11, 9, 21, 42, 216, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Teachers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 11, 9, 24, 44, 57, DateTimeKind.Local).AddTicks(6797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 11, 11, 9, 21, 42, 217, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 11, 9, 24, 44, 57, DateTimeKind.Local).AddTicks(4584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 11, 11, 9, 21, 42, 216, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 11, 9, 24, 44, 53, DateTimeKind.Local).AddTicks(8496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 11, 11, 9, 21, 42, 212, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 11, 9, 24, 44, 56, DateTimeKind.Local).AddTicks(8148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 11, 11, 9, 21, 42, 216, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 11, 9, 24, 44, 52, DateTimeKind.Local).AddTicks(7767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 11, 11, 9, 21, 42, 211, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 11, 9, 24, 44, 54, DateTimeKind.Local).AddTicks(170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 11, 11, 9, 21, 42, 213, DateTimeKind.Local).AddTicks(641));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 11, 11, 9, 21, 42, 216, DateTimeKind.Local).AddTicks(4096),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 11, 9, 24, 44, 57, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserRoles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 11, 11, 9, 21, 42, 216, DateTimeKind.Local).AddTicks(7275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 11, 9, 24, 44, 57, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Teachers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 11, 11, 9, 21, 42, 217, DateTimeKind.Local).AddTicks(2142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 11, 9, 24, 44, 57, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Students",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 11, 11, 9, 21, 42, 216, DateTimeKind.Local).AddTicks(9840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 11, 9, 24, 44, 57, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Settings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 11, 11, 9, 21, 42, 212, DateTimeKind.Local).AddTicks(8954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 11, 9, 24, 44, 53, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Roles",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 11, 11, 9, 21, 42, 216, DateTimeKind.Local).AddTicks(1132),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 11, 9, 24, 44, 56, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Messages",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 11, 11, 9, 21, 42, 211, DateTimeKind.Local).AddTicks(6911),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 11, 9, 24, 44, 52, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Groups",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 11, 11, 9, 21, 42, 213, DateTimeKind.Local).AddTicks(641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 11, 9, 24, 44, 54, DateTimeKind.Local).AddTicks(170));
        }
    }
}
