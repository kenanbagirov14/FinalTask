using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class fullFilePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 1, 26, 34, 853, DateTimeKind.Local).AddTicks(5367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 12, 11, 13, 24, 411, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 1, 26, 34, 853, DateTimeKind.Local).AddTicks(8566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 12, 11, 13, 24, 411, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Teachers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 1, 26, 34, 854, DateTimeKind.Local).AddTicks(3937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 12, 11, 13, 24, 412, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.AddColumn<string>(
                name: "ImagaFullPath",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 1, 26, 34, 854, DateTimeKind.Local).AddTicks(1126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 12, 11, 13, 24, 411, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.AddColumn<string>(
                name: "ImagaFullPath",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 1, 26, 34, 852, DateTimeKind.Local).AddTicks(5362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 12, 11, 13, 24, 409, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.AddColumn<string>(
                name: "LogoImageFullPath",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SlideImageFullPath",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 1, 26, 34, 853, DateTimeKind.Local).AddTicks(2068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 12, 11, 13, 24, 410, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 1, 26, 34, 852, DateTimeKind.Local).AddTicks(2381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 12, 11, 13, 24, 409, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 16, 1, 26, 34, 852, DateTimeKind.Local).AddTicks(8407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 12, 11, 13, 24, 410, DateTimeKind.Local).AddTicks(724));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagaFullPath",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ImagaFullPath",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LogoImageFullPath",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "SlideImageFullPath",
                table: "Settings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 12, 11, 13, 24, 411, DateTimeKind.Local).AddTicks(2760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 1, 26, 34, 853, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 12, 11, 13, 24, 411, DateTimeKind.Local).AddTicks(7163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 1, 26, 34, 853, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Teachers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 12, 11, 13, 24, 412, DateTimeKind.Local).AddTicks(2829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 1, 26, 34, 854, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 12, 11, 13, 24, 411, DateTimeKind.Local).AddTicks(9691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 1, 26, 34, 854, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 12, 11, 13, 24, 409, DateTimeKind.Local).AddTicks(8130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 1, 26, 34, 852, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 12, 11, 13, 24, 410, DateTimeKind.Local).AddTicks(7785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 1, 26, 34, 853, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 12, 11, 13, 24, 409, DateTimeKind.Local).AddTicks(4997),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 1, 26, 34, 852, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 12, 11, 13, 24, 410, DateTimeKind.Local).AddTicks(724),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 16, 1, 26, 34, 852, DateTimeKind.Local).AddTicks(8407));
        }
    }
}
