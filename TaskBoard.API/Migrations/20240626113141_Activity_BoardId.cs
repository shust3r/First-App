using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskBoard.API.Migrations
{
    /// <inheritdoc />
    public partial class Activity_BoardId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BoardId",
                table: "Activities",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BoardId", "OperationDate" },
                values: new object[] { 0, new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BoardId", "OperationDate" },
                values: new object[] { 0, new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BoardId", "OperationDate" },
                values: new object[] { 0, new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BoardId", "OperationDate" },
                values: new object[] { 0, new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BoardId", "OperationDate" },
                values: new object[] { 0, new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BoardId", "OperationDate" },
                values: new object[] { 0, new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BoardId", "OperationDate" },
                values: new object[] { 0, new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BoardId", "OperationDate" },
                values: new object[] { 0, new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BoardId", "OperationDate" },
                values: new object[] { 0, new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BoardId", "OperationDate" },
                values: new object[] { 0, new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BoardId", "OperationDate" },
                values: new object[] { 0, new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BoardId", "OperationDate" },
                values: new object[] { 0, new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BoardId", "OperationDate" },
                values: new object[] { 0, new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2024, 6, 28, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2024, 6, 28, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2024, 6, 28, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "DueDate",
                value: new DateTime(2024, 6, 27, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "DueDate",
                value: new DateTime(2024, 6, 27, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "DueDate",
                value: new DateTime(2024, 6, 30, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "DueDate",
                value: new DateTime(2024, 6, 30, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                column: "DueDate",
                value: new DateTime(2024, 7, 1, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                column: "DueDate",
                value: new DateTime(2024, 7, 1, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                column: "DueDate",
                value: new DateTime(2024, 6, 29, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                column: "DueDate",
                value: new DateTime(2024, 6, 27, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                column: "DueDate",
                value: new DateTime(2024, 6, 30, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                column: "DueDate",
                value: new DateTime(2024, 6, 30, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5980));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BoardId",
                table: "Activities");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "OperationDate",
                value: new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "OperationDate",
                value: new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "OperationDate",
                value: new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "OperationDate",
                value: new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "OperationDate",
                value: new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "OperationDate",
                value: new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "OperationDate",
                value: new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "OperationDate",
                value: new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "OperationDate",
                value: new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "OperationDate",
                value: new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 11,
                column: "OperationDate",
                value: new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 12,
                column: "OperationDate",
                value: new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 13,
                column: "OperationDate",
                value: new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2024, 6, 24, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2024, 6, 24, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2024, 6, 24, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "DueDate",
                value: new DateTime(2024, 6, 23, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "DueDate",
                value: new DateTime(2024, 6, 23, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "DueDate",
                value: new DateTime(2024, 6, 26, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "DueDate",
                value: new DateTime(2024, 6, 26, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                column: "DueDate",
                value: new DateTime(2024, 6, 27, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                column: "DueDate",
                value: new DateTime(2024, 6, 27, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                column: "DueDate",
                value: new DateTime(2024, 6, 25, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                column: "DueDate",
                value: new DateTime(2024, 6, 23, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                column: "DueDate",
                value: new DateTime(2024, 6, 26, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                column: "DueDate",
                value: new DateTime(2024, 6, 26, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5732));
        }
    }
}
