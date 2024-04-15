using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CourseConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedAt", "EndAt", "FilialId", "LessonEndAt", "LessonStartAt", "Name", "SpecialityId", "StartAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 4, 14, 2, 43, 39, 880, DateTimeKind.Local).AddTicks(5448), new DateOnly(2024, 4, 14), 1L, new TimeOnly(2, 43, 39, 880).Add(TimeSpan.FromTicks(5469)), new TimeOnly(2, 43, 39, 880).Add(TimeSpan.FromTicks(5460)), ".Net bootcamp", 1L, new DateOnly(2024, 4, 14), new DateTime(2024, 4, 14, 2, 43, 39, 880, DateTimeKind.Local).AddTicks(5448) },
                    { 2L, new DateTime(2024, 4, 14, 2, 43, 39, 880, DateTimeKind.Local).AddTicks(5471), new DateOnly(2024, 4, 14), 1L, new TimeOnly(2, 43, 39, 880).Add(TimeSpan.FromTicks(5473)), new TimeOnly(2, 43, 39, 880).Add(TimeSpan.FromTicks(5473)), ".Net bootcamp 1", 1L, new DateOnly(2024, 4, 14), new DateTime(2024, 4, 14, 2, 43, 39, 880, DateTimeKind.Local).AddTicks(5471) },
                    { 3L, new DateTime(2024, 4, 14, 2, 43, 39, 880, DateTimeKind.Local).AddTicks(5474), new DateOnly(2024, 4, 14), 1L, new TimeOnly(2, 43, 39, 880).Add(TimeSpan.FromTicks(5477)), new TimeOnly(2, 43, 39, 880).Add(TimeSpan.FromTicks(5477)), ".Net bootcamp 2", 1L, new DateOnly(2024, 4, 14), new DateTime(2024, 4, 14, 2, 43, 39, 880, DateTimeKind.Local).AddTicks(5475) }
                });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 13, 21, 43, 39, 880, DateTimeKind.Utc).AddTicks(5216), new DateTime(2024, 4, 14, 2, 43, 39, 880, DateTimeKind.Local).AddTicks(5221) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 13, 21, 43, 39, 880, DateTimeKind.Utc).AddTicks(5235), new DateTime(2024, 4, 14, 2, 43, 39, 880, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 13, 21, 43, 39, 880, DateTimeKind.Utc).AddTicks(5237), new DateTime(2024, 4, 14, 2, 43, 39, 880, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 13, 21, 43, 39, 880, DateTimeKind.Utc).AddTicks(5238), new DateTime(2024, 4, 14, 2, 43, 39, 880, DateTimeKind.Local).AddTicks(5239) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 13, 21, 9, 52, 317, DateTimeKind.Utc).AddTicks(2946), new DateTime(2024, 4, 14, 2, 9, 52, 317, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 13, 21, 9, 52, 317, DateTimeKind.Utc).AddTicks(2963), new DateTime(2024, 4, 14, 2, 9, 52, 317, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 13, 21, 9, 52, 317, DateTimeKind.Utc).AddTicks(2965), new DateTime(2024, 4, 14, 2, 9, 52, 317, DateTimeKind.Local).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 13, 21, 9, 52, 317, DateTimeKind.Utc).AddTicks(2966), new DateTime(2024, 4, 14, 2, 9, 52, 317, DateTimeKind.Local).AddTicks(2967) });
        }
    }
}
