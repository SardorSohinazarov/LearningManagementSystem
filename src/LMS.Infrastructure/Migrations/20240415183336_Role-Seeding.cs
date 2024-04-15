using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RoleSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "LessonEndAt", "LessonStartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8547), new TimeOnly(23, 33, 35, 481).Add(TimeSpan.FromTicks(8563)), new TimeOnly(23, 33, 35, 481).Add(TimeSpan.FromTicks(8557)), new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "LessonEndAt", "LessonStartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8567), new TimeOnly(23, 33, 35, 481).Add(TimeSpan.FromTicks(8569)), new TimeOnly(23, 33, 35, 481).Add(TimeSpan.FromTicks(8569)), new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "LessonEndAt", "LessonStartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8585), new TimeOnly(23, 33, 35, 481).Add(TimeSpan.FromTicks(8589)), new TimeOnly(23, 33, 35, 481).Add(TimeSpan.FromTicks(8588)), new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 18, 33, 35, 481, DateTimeKind.Utc).AddTicks(8328), new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 18, 33, 35, 481, DateTimeKind.Utc).AddTicks(8332), new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 18, 33, 35, 481, DateTimeKind.Utc).AddTicks(8334), new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 18, 33, 35, 481, DateTimeKind.Utc).AddTicks(8336), new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8704), "Asistent", new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8705) },
                    { 2L, new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8707), "Teacher", new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8707) },
                    { 3L, new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8709), "Admin", new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8709) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "LessonEndAt", "LessonStartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 30, 44, 955, DateTimeKind.Local).AddTicks(4293), new TimeOnly(23, 30, 44, 955).Add(TimeSpan.FromTicks(4312)), new TimeOnly(23, 30, 44, 955).Add(TimeSpan.FromTicks(4304)), new DateTime(2024, 4, 15, 23, 30, 44, 955, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "LessonEndAt", "LessonStartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 30, 44, 955, DateTimeKind.Local).AddTicks(4315), new TimeOnly(23, 30, 44, 955).Add(TimeSpan.FromTicks(4318)), new TimeOnly(23, 30, 44, 955).Add(TimeSpan.FromTicks(4317)), new DateTime(2024, 4, 15, 23, 30, 44, 955, DateTimeKind.Local).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "LessonEndAt", "LessonStartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 30, 44, 955, DateTimeKind.Local).AddTicks(4336), new TimeOnly(23, 30, 44, 955).Add(TimeSpan.FromTicks(4338)), new TimeOnly(23, 30, 44, 955).Add(TimeSpan.FromTicks(4338)), new DateTime(2024, 4, 15, 23, 30, 44, 955, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 18, 30, 44, 955, DateTimeKind.Utc).AddTicks(4070), new DateTime(2024, 4, 15, 23, 30, 44, 955, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 18, 30, 44, 955, DateTimeKind.Utc).AddTicks(4073), new DateTime(2024, 4, 15, 23, 30, 44, 955, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 18, 30, 44, 955, DateTimeKind.Utc).AddTicks(4075), new DateTime(2024, 4, 15, 23, 30, 44, 955, DateTimeKind.Local).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 18, 30, 44, 955, DateTimeKind.Utc).AddTicks(4077), new DateTime(2024, 4, 15, 23, 30, 44, 955, DateTimeKind.Local).AddTicks(4078) });
        }
    }
}
