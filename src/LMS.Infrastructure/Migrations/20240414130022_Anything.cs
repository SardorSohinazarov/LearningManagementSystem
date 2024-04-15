using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Anything : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeworkFile_Homeworks_HomeworkId",
                table: "HomeworkFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HomeworkFile",
                table: "HomeworkFile");

            migrationBuilder.RenameTable(
                name: "HomeworkFile",
                newName: "HomeworkFiles");

            migrationBuilder.RenameIndex(
                name: "IX_HomeworkFile_HomeworkId",
                table: "HomeworkFiles",
                newName: "IX_HomeworkFiles_HomeworkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HomeworkFiles",
                table: "HomeworkFiles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeworkStudents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeworkId = table.Column<long>(type: "bigint", nullable: false),
                    StudentId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeworkStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeworkStudents_Homeworks_HomeworkId",
                        column: x => x.HomeworkId,
                        principalTable: "Homeworks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HomeworkStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeworkStudentFiles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeworkStudentId = table.Column<long>(type: "bigint", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeworkStudentFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeworkStudentFiles_HomeworkStudents_HomeworkStudentId",
                        column: x => x.HomeworkStudentId,
                        principalTable: "HomeworkStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "LessonEndAt", "LessonStartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 14, 18, 0, 21, 702, DateTimeKind.Local).AddTicks(5141), new TimeOnly(18, 0, 21, 702).Add(TimeSpan.FromTicks(5159)), new TimeOnly(18, 0, 21, 702).Add(TimeSpan.FromTicks(5152)), new DateTime(2024, 4, 14, 18, 0, 21, 702, DateTimeKind.Local).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "LessonEndAt", "LessonStartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 14, 18, 0, 21, 702, DateTimeKind.Local).AddTicks(5161), new TimeOnly(18, 0, 21, 702).Add(TimeSpan.FromTicks(5164)), new TimeOnly(18, 0, 21, 702).Add(TimeSpan.FromTicks(5163)), new DateTime(2024, 4, 14, 18, 0, 21, 702, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "LessonEndAt", "LessonStartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 14, 18, 0, 21, 702, DateTimeKind.Local).AddTicks(5165), new TimeOnly(18, 0, 21, 702).Add(TimeSpan.FromTicks(5168)), new TimeOnly(18, 0, 21, 702).Add(TimeSpan.FromTicks(5168)), new DateTime(2024, 4, 14, 18, 0, 21, 702, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 14, 13, 0, 21, 702, DateTimeKind.Utc).AddTicks(4885), new DateTime(2024, 4, 14, 18, 0, 21, 702, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 14, 13, 0, 21, 702, DateTimeKind.Utc).AddTicks(4909), new DateTime(2024, 4, 14, 18, 0, 21, 702, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 14, 13, 0, 21, 702, DateTimeKind.Utc).AddTicks(4911), new DateTime(2024, 4, 14, 18, 0, 21, 702, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 14, 13, 0, 21, 702, DateTimeKind.Utc).AddTicks(4912), new DateTime(2024, 4, 14, 18, 0, 21, 702, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.CreateIndex(
                name: "IX_HomeworkStudentFiles_HomeworkStudentId",
                table: "HomeworkStudentFiles",
                column: "HomeworkStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeworkStudents_HomeworkId",
                table: "HomeworkStudents",
                column: "HomeworkId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeworkStudents_StudentId",
                table: "HomeworkStudents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeworkFiles_Homeworks_HomeworkId",
                table: "HomeworkFiles",
                column: "HomeworkId",
                principalTable: "Homeworks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeworkFiles_Homeworks_HomeworkId",
                table: "HomeworkFiles");

            migrationBuilder.DropTable(
                name: "HomeworkStudentFiles");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "HomeworkStudents");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HomeworkFiles",
                table: "HomeworkFiles");

            migrationBuilder.RenameTable(
                name: "HomeworkFiles",
                newName: "HomeworkFile");

            migrationBuilder.RenameIndex(
                name: "IX_HomeworkFiles_HomeworkId",
                table: "HomeworkFile",
                newName: "IX_HomeworkFile_HomeworkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HomeworkFile",
                table: "HomeworkFile",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_HomeworkFile_Homeworks_HomeworkId",
                table: "HomeworkFile",
                column: "HomeworkId",
                principalTable: "Homeworks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
