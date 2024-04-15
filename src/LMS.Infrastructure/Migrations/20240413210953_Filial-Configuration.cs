using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FilialConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Filial_FilialId",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Filial",
                table: "Filial");

            migrationBuilder.RenameTable(
                name: "Filial",
                newName: "Filials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filials",
                table: "Filials",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Filials",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 4, 13, 21, 9, 52, 317, DateTimeKind.Utc).AddTicks(2946), "Chilonzor", new DateTime(2024, 4, 14, 2, 9, 52, 317, DateTimeKind.Local).AddTicks(2950) },
                    { 2L, new DateTime(2024, 4, 13, 21, 9, 52, 317, DateTimeKind.Utc).AddTicks(2963), "Chimboy", new DateTime(2024, 4, 14, 2, 9, 52, 317, DateTimeKind.Local).AddTicks(2964) },
                    { 3L, new DateTime(2024, 4, 13, 21, 9, 52, 317, DateTimeKind.Utc).AddTicks(2965), "Farg'ona", new DateTime(2024, 4, 14, 2, 9, 52, 317, DateTimeKind.Local).AddTicks(2965) },
                    { 4L, new DateTime(2024, 4, 13, 21, 9, 52, 317, DateTimeKind.Utc).AddTicks(2966), "Xorazmiy", new DateTime(2024, 4, 14, 2, 9, 52, 317, DateTimeKind.Local).AddTicks(2967) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Filials_FilialId",
                table: "Courses",
                column: "FilialId",
                principalTable: "Filials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Filials_FilialId",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Filials",
                table: "Filials");

            migrationBuilder.DeleteData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Filials",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.RenameTable(
                name: "Filials",
                newName: "Filial");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filial",
                table: "Filial",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Filial_FilialId",
                table: "Courses",
                column: "FilialId",
                principalTable: "Filial",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
