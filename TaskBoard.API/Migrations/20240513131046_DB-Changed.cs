using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskBoard.API.Migrations
{
    /// <inheritdoc />
    public partial class DBChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "DueDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "DueDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "DueDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "DueDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                column: "DueDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                column: "DueDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                column: "DueDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Lists",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Third List" },
                    { 4, "Fourth List" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Description", "DueDate", "ListId", "Name", "Priority" },
                values: new object[,]
                {
                    { 11, "Task description should be unambiguous, accurate, factual.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Card 11", 1 },
                    { 12, "Task description should be unambiguous, accurate, factual.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Card 12", 1 },
                    { 13, "Task description should be unambiguous, accurate, factual.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Card 13", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 4);

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
    }
}
