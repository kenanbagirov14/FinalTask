using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class rw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 17, 4, 56, 2, 672, DateTimeKind.Local).AddTicks(5368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 17, 0, 45, 56, 133, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 17, 4, 56, 2, 672, DateTimeKind.Local).AddTicks(7768),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 17, 0, 45, 56, 134, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Teachers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 17, 4, 56, 2, 673, DateTimeKind.Local).AddTicks(1767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 17, 0, 45, 56, 134, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.AddColumn<string>(
                name: "Descripption",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 17, 4, 56, 2, 672, DateTimeKind.Local).AddTicks(9509),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 17, 0, 45, 56, 134, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 17, 4, 56, 2, 671, DateTimeKind.Local).AddTicks(8538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 17, 0, 45, 56, 133, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.AddColumn<string>(
                name: "AboutFullImagePath",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutImagePath",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutTittle",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhyUsFullImagePath",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhyUsFullImagePath1",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhyUsFullImagePath2",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhyUsImagePath",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhyUsImagePath1",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhyUsImagePath2",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhyUsText",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhyUsText1",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhyUsText2",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhyUsTittle",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhyUsTittle1",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhyUsTittle2",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 17, 4, 56, 2, 672, DateTimeKind.Local).AddTicks(3015),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 17, 0, 45, 56, 133, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 17, 4, 56, 2, 671, DateTimeKind.Local).AddTicks(6262),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 17, 0, 45, 56, 133, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 17, 4, 56, 2, 672, DateTimeKind.Local).AddTicks(426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 17, 0, 45, 56, 133, DateTimeKind.Local).AddTicks(3759));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripption",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "AboutFullImagePath",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "AboutImagePath",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "AboutTittle",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "WhyUsFullImagePath",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "WhyUsFullImagePath1",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "WhyUsFullImagePath2",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "WhyUsImagePath",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "WhyUsImagePath1",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "WhyUsImagePath2",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "WhyUsText",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "WhyUsText1",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "WhyUsText2",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "WhyUsTittle",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "WhyUsTittle1",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "WhyUsTittle2",
                table: "Settings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 17, 0, 45, 56, 133, DateTimeKind.Local).AddTicks(9135),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 17, 4, 56, 2, 672, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 17, 0, 45, 56, 134, DateTimeKind.Local).AddTicks(1430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 17, 4, 56, 2, 672, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Teachers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 17, 0, 45, 56, 134, DateTimeKind.Local).AddTicks(5213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 17, 4, 56, 2, 673, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 17, 0, 45, 56, 134, DateTimeKind.Local).AddTicks(3162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 17, 4, 56, 2, 672, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 17, 0, 45, 56, 133, DateTimeKind.Local).AddTicks(2125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 17, 4, 56, 2, 671, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 17, 0, 45, 56, 133, DateTimeKind.Local).AddTicks(6887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 17, 4, 56, 2, 672, DateTimeKind.Local).AddTicks(3015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 17, 0, 45, 56, 133, DateTimeKind.Local).AddTicks(13),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 17, 4, 56, 2, 671, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 17, 0, 45, 56, 133, DateTimeKind.Local).AddTicks(3759),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 17, 4, 56, 2, 672, DateTimeKind.Local).AddTicks(426));
        }
    }
}
