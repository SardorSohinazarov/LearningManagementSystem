using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Homeworks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Homeworks",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<long>(type: "bigint", nullable: false),
                    TeacherId = table.Column<long>(type: "bigint", nullable: false),
                    LessonId = table.Column<long>(type: "bigint", nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homeworks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Homeworks_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeworkFile",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeworkId = table.Column<long>(type: "bigint", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeworkFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeworkFile_Homeworks_HomeworkId",
                        column: x => x.HomeworkId,
                        principalTable: "Homeworks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "LessonEndAt", "LessonStartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1629), new TimeOnly(4, 45, 48, 793).Add(TimeSpan.FromTicks(1667)), new TimeOnly(4, 45, 48, 793).Add(TimeSpan.FromTicks(1655)), new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "LessonEndAt", "LessonStartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1671), new TimeOnly(4, 45, 48, 793).Add(TimeSpan.FromTicks(1675)), new TimeOnly(4, 45, 48, 793).Add(TimeSpan.FromTicks(1674)), new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "LessonEndAt", "LessonStartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1677), new TimeOnly(4, 45, 48, 793).Add(TimeSpan.FromTicks(1680)), new TimeOnly(4, 45, 48, 793).Add(TimeSpan.FromTicks(1679)), new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 13, 23, 45, 48, 793, DateTimeKind.Utc).AddTicks(1245), new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1256) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 13, 23, 45, 48, 793, DateTimeKind.Utc).AddTicks(1284), new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 13, 23, 45, 48, 793, DateTimeKind.Utc).AddTicks(1285), new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 13, 23, 45, 48, 793, DateTimeKind.Utc).AddTicks(1287), new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1287) });

            migrationBuilder.CreateIndex(
                name: "IX_HomeworkFile_HomeworkId",
                table: "HomeworkFile",
                column: "HomeworkId");

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_LessonId",
                table: "Homeworks",
                column: "LessonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomeworkFile");

            migrationBuilder.DropTable(
                name: "Homeworks");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "LessonEndAt", "LessonStartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 14, 2, 43, 39, 880, DateTimeKind.Local).AddTicks(5448), new TimeOnly(2, 43, 39, 880).Add(TimeSpan.FromTicks(5469)), new TimeOnly(2, 43, 39, 880).Add(TimeSpan.FromTicks(5460)), new DateTime(2024, 4, 14, 2, 43, 39, 880, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "LessonEndAt", "LessonStartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 14, 2, 43, 39, 880, DateTimeKind.Local).AddTicks(5471), new TimeOnly(2, 43, 39, 880).Add(TimeSpan.FromTicks(5473)), new TimeOnly(2, 43, 39, 880).Add(TimeSpan.FromTicks(5473)), new DateTime(2024, 4, 14, 2, 43, 39, 880, DateTimeKind.Local).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "LessonEndAt", "LessonStartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 14, 2, 43, 39, 880, DateTimeKind.Local).AddTicks(5474), new TimeOnly(2, 43, 39, 880).Add(TimeSpan.FromTicks(5477)), new TimeOnly(2, 43, 39, 880).Add(TimeSpan.FromTicks(5477)), new DateTime(2024, 4, 14, 2, 43, 39, 880, DateTimeKind.Local).AddTicks(5475) });

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
    }
}
