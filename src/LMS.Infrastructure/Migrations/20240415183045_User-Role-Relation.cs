using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserRoleRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfilePhotoPath",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "EndAt", "LessonEndAt", "LessonStartAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 30, 44, 955, DateTimeKind.Local).AddTicks(4293), new DateOnly(2024, 4, 15), new TimeOnly(23, 30, 44, 955).Add(TimeSpan.FromTicks(4312)), new TimeOnly(23, 30, 44, 955).Add(TimeSpan.FromTicks(4304)), new DateOnly(2024, 4, 15), new DateTime(2024, 4, 15, 23, 30, 44, 955, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "EndAt", "LessonEndAt", "LessonStartAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 30, 44, 955, DateTimeKind.Local).AddTicks(4315), new DateOnly(2024, 4, 15), new TimeOnly(23, 30, 44, 955).Add(TimeSpan.FromTicks(4318)), new TimeOnly(23, 30, 44, 955).Add(TimeSpan.FromTicks(4317)), new DateOnly(2024, 4, 15), new DateTime(2024, 4, 15, 23, 30, 44, 955, DateTimeKind.Local).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "EndAt", "LessonEndAt", "LessonStartAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 30, 44, 955, DateTimeKind.Local).AddTicks(4336), new DateOnly(2024, 4, 15), new TimeOnly(23, 30, 44, 955).Add(TimeSpan.FromTicks(4338)), new TimeOnly(23, 30, 44, 955).Add(TimeSpan.FromTicks(4338)), new DateOnly(2024, 4, 15), new DateTime(2024, 4, 15, 23, 30, 44, 955, DateTimeKind.Local).AddTicks(4336) });

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePhotoPath",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "EndAt", "LessonEndAt", "LessonStartAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 14, 18, 0, 21, 702, DateTimeKind.Local).AddTicks(5141), new DateOnly(2024, 4, 14), new TimeOnly(18, 0, 21, 702).Add(TimeSpan.FromTicks(5159)), new TimeOnly(18, 0, 21, 702).Add(TimeSpan.FromTicks(5152)), new DateOnly(2024, 4, 14), new DateTime(2024, 4, 14, 18, 0, 21, 702, DateTimeKind.Local).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "EndAt", "LessonEndAt", "LessonStartAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 14, 18, 0, 21, 702, DateTimeKind.Local).AddTicks(5161), new DateOnly(2024, 4, 14), new TimeOnly(18, 0, 21, 702).Add(TimeSpan.FromTicks(5164)), new TimeOnly(18, 0, 21, 702).Add(TimeSpan.FromTicks(5163)), new DateOnly(2024, 4, 14), new DateTime(2024, 4, 14, 18, 0, 21, 702, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "EndAt", "LessonEndAt", "LessonStartAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 14, 18, 0, 21, 702, DateTimeKind.Local).AddTicks(5165), new DateOnly(2024, 4, 14), new TimeOnly(18, 0, 21, 702).Add(TimeSpan.FromTicks(5168)), new TimeOnly(18, 0, 21, 702).Add(TimeSpan.FromTicks(5168)), new DateOnly(2024, 4, 14), new DateTime(2024, 4, 14, 18, 0, 21, 702, DateTimeKind.Local).AddTicks(5166) });

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
        }
    }
}
