using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlcVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AllLocalImagePathForVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageLocalPath",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ImageLocalPath" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 58, 7, 391, DateTimeKind.Local).AddTicks(437), "" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ImageLocalPath" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 58, 7, 391, DateTimeKind.Local).AddTicks(460), "" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ImageLocalPath" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 58, 7, 391, DateTimeKind.Local).AddTicks(462), "" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ImageLocalPath" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 58, 7, 391, DateTimeKind.Local).AddTicks(465), "" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ImageLocalPath" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 58, 7, 391, DateTimeKind.Local).AddTicks(466), "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageLocalPath",
                table: "Villas");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 27, 20, 36, 13, 475, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 5, 27, 20, 36, 13, 475, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 5, 27, 20, 36, 13, 475, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 5, 27, 20, 36, 13, 475, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 5, 27, 20, 36, 13, 475, DateTimeKind.Local).AddTicks(2701));
        }
    }
}
