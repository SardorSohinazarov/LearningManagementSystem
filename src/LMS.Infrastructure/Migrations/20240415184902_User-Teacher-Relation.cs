using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserTeacherRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "LessonEndAt", "LessonStartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 49, 1, 711, DateTimeKind.Local).AddTicks(6285), new TimeOnly(23, 49, 1, 711).Add(TimeSpan.FromTicks(6305)), new TimeOnly(23, 49, 1, 711).Add(TimeSpan.FromTicks(6297)), new DateTime(2024, 4, 15, 23, 49, 1, 711, DateTimeKind.Local).AddTicks(6286) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "LessonEndAt", "LessonStartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 49, 1, 711, DateTimeKind.Local).AddTicks(6309), new TimeOnly(23, 49, 1, 711).Add(TimeSpan.FromTicks(6313)), new TimeOnly(23, 49, 1, 711).Add(TimeSpan.FromTicks(6312)), new DateTime(2024, 4, 15, 23, 49, 1, 711, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "LessonEndAt", "LessonStartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 49, 1, 711, DateTimeKind.Local).AddTicks(6316), new TimeOnly(23, 49, 1, 711).Add(TimeSpan.FromTicks(6320)), new TimeOnly(23, 49, 1, 711).Add(TimeSpan.FromTicks(6319)), new DateTime(2024, 4, 15, 23, 49, 1, 711, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 18, 49, 1, 711, DateTimeKind.Utc).AddTicks(5798), new DateTime(2024, 4, 15, 23, 49, 1, 711, DateTimeKind.Local).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 18, 49, 1, 711, DateTimeKind.Utc).AddTicks(5801), new DateTime(2024, 4, 15, 23, 49, 1, 711, DateTimeKind.Local).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 18, 49, 1, 711, DateTimeKind.Utc).AddTicks(5803), new DateTime(2024, 4, 15, 23, 49, 1, 711, DateTimeKind.Local).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 18, 49, 1, 711, DateTimeKind.Utc).AddTicks(5805), new DateTime(2024, 4, 15, 23, 49, 1, 711, DateTimeKind.Local).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 49, 1, 711, DateTimeKind.Local).AddTicks(6455), new DateTime(2024, 4, 15, 23, 49, 1, 711, DateTimeKind.Local).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 49, 1, 711, DateTimeKind.Local).AddTicks(6458), new DateTime(2024, 4, 15, 23, 49, 1, 711, DateTimeKind.Local).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 49, 1, 711, DateTimeKind.Local).AddTicks(6461), new DateTime(2024, 4, 15, 23, 49, 1, 711, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers");

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

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8704), new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8707), new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8709), new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8709) });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId");
        }
    }
}
