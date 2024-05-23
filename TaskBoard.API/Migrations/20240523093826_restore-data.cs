using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskBoard.API.Migrations
{
    /// <inheritdoc />
    public partial class restoredata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "OperationDate",
                value: new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "OperationDate",
                value: new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "OperationDate",
                value: new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "OperationDate",
                value: new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "OperationDate",
                value: new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "OperationDate",
                value: new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "OperationDate",
                value: new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "OperationDate",
                value: new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "OperationDate",
                value: new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "OperationDate",
                value: new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 11,
                column: "OperationDate",
                value: new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 12,
                column: "OperationDate",
                value: new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 13,
                column: "OperationDate",
                value: new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2024, 5, 25, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2024, 5, 25, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2024, 5, 25, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "DueDate",
                value: new DateTime(2024, 5, 24, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "DueDate",
                value: new DateTime(2024, 5, 24, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "DueDate",
                value: new DateTime(2024, 5, 24, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "DueDate",
                value: new DateTime(2024, 5, 27, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                column: "DueDate",
                value: new DateTime(2024, 5, 27, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                column: "DueDate",
                value: new DateTime(2024, 5, 27, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                column: "DueDate",
                value: new DateTime(2024, 5, 27, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                column: "DueDate",
                value: new DateTime(2024, 5, 28, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                column: "DueDate",
                value: new DateTime(2024, 5, 28, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                column: "DueDate",
                value: new DateTime(2024, 5, 26, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4084));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "OperationDate",
                value: new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "OperationDate",
                value: new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "OperationDate",
                value: new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "OperationDate",
                value: new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "OperationDate",
                value: new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "OperationDate",
                value: new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "OperationDate",
                value: new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "OperationDate",
                value: new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "OperationDate",
                value: new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "OperationDate",
                value: new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 11,
                column: "OperationDate",
                value: new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 12,
                column: "OperationDate",
                value: new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 13,
                column: "OperationDate",
                value: new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2024, 5, 24, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2024, 5, 24, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2024, 5, 24, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "DueDate",
                value: new DateTime(2024, 5, 23, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "DueDate",
                value: new DateTime(2024, 5, 23, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "DueDate",
                value: new DateTime(2024, 5, 23, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "DueDate",
                value: new DateTime(2024, 5, 26, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                column: "DueDate",
                value: new DateTime(2024, 5, 26, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                column: "DueDate",
                value: new DateTime(2024, 5, 26, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                column: "DueDate",
                value: new DateTime(2024, 5, 26, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                column: "DueDate",
                value: new DateTime(2024, 5, 27, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                column: "DueDate",
                value: new DateTime(2024, 5, 27, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                column: "DueDate",
                value: new DateTime(2024, 5, 25, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5212));
        }
    }
}
