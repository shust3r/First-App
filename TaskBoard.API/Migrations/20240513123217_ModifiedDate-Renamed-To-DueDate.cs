using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskBoard.API.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedDateRenamedToDueDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Cards",
                newName: "DueDate");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2024, 5, 3, 12, 32, 15, 125, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2024, 5, 4, 12, 32, 15, 125, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2024, 5, 5, 12, 32, 15, 125, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "DueDate",
                value: new DateTime(2024, 5, 6, 12, 32, 15, 125, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "DueDate",
                value: new DateTime(2024, 5, 7, 12, 32, 15, 125, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "DueDate",
                value: new DateTime(2024, 5, 8, 12, 32, 15, 125, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "DueDate",
                value: new DateTime(2024, 5, 9, 12, 32, 15, 125, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                column: "DueDate",
                value: new DateTime(2024, 5, 10, 12, 32, 15, 125, DateTimeKind.Utc).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                column: "DueDate",
                value: new DateTime(2024, 5, 11, 12, 32, 15, 125, DateTimeKind.Utc).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                column: "DueDate",
                value: new DateTime(2024, 5, 12, 12, 32, 15, 125, DateTimeKind.Utc).AddTicks(4686));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DueDate",
                table: "Cards",
                newName: "ModifiedDate");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2024, 4, 29, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2024, 4, 30, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2024, 5, 1, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2024, 5, 2, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedDate",
                value: new DateTime(2024, 5, 3, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedDate",
                value: new DateTime(2024, 5, 4, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedDate",
                value: new DateTime(2024, 5, 5, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedDate",
                value: new DateTime(2024, 5, 6, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedDate",
                value: new DateTime(2024, 5, 7, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedDate",
                value: new DateTime(2024, 5, 8, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7786));
        }
    }
}
