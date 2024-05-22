using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskBoard.API.Migrations
{
    /// <inheritdoc />
    public partial class ListName_CardName_for_Activity_Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardName",
                table: "Activities",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ListName",
                table: "Activities",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CardName", "ListName", "OperationDate", "OperationName" },
                values: new object[] { "Card Name 1", "Urgent", new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5255), "added" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CardName", "ListName", "OperationDate", "OperationName" },
                values: new object[] { "Card 2", "Urgent", new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5257), "added" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CardName", "ListName", "OperationDate", "OperationName" },
                values: new object[] { "Card Name 3", "Urgent", new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5259), "added" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CardName", "ListName", "OperationDate", "OperationName" },
                values: new object[] { "Card 4", "Urgent", new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5260), "added" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CardName", "ListName", "OperationDate", "OperationName" },
                values: new object[] { "Card Name 5", "Urgent", new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5262), "added" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CardName", "ListName", "OperationDate", "OperationName" },
                values: new object[] { "Card 6", "Second List", new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5263), "added" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CardName", "ListName", "OperationDate", "OperationName" },
                values: new object[] { "Card Name 7", "Second List", new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5264), "added" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CardName", "ListName", "OperationDate", "OperationName" },
                values: new object[] { "Card 8", "Second List", new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5266), "added" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CardName", "ListName", "OperationDate", "OperationName" },
                values: new object[] { "Card Name 9", "Second List", new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5267), "added" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CardName", "ListName", "OperationDate", "OperationName" },
                values: new object[] { "Card 10", "Second List", new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5268), "added" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CardName", "ListName", "OperationDate", "OperationName" },
                values: new object[] { "Card 11", "Third List", new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5270), "added" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CardName", "ListName", "OperationDate", "OperationName" },
                values: new object[] { "Card 12", "Fourth List", new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5271), "added" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CardName", "ListName", "OperationDate", "OperationName", "ValueAfter" },
                values: new object[] { "Card Name 13", "Fourth List", new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5273), "added", "Fix Activity UI" });

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

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Urgent");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardName",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "ListName",
                table: "Activities");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OperationDate", "OperationName" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(750), "add" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OperationDate", "OperationName" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(752), "add" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "OperationDate", "OperationName" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(753), "add" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OperationDate", "OperationName" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(754), "add" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "OperationDate", "OperationName" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(756), "add" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "OperationDate", "OperationName" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(757), "add" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "OperationDate", "OperationName" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(758), "add" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "OperationDate", "OperationName" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(760), "add" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "OperationDate", "OperationName" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(761), "add" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "OperationDate", "OperationName" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(762), "add" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "OperationDate", "OperationName" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(763), "add" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "OperationDate", "OperationName" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(765), "add" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "OperationDate", "OperationName", "ValueAfter" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(766), "add", "Card 13" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2024, 5, 14, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2024, 5, 14, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2024, 5, 14, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "DueDate",
                value: new DateTime(2024, 5, 14, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "DueDate",
                value: new DateTime(2024, 5, 14, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "DueDate",
                value: new DateTime(2024, 5, 14, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "DueDate",
                value: new DateTime(2024, 5, 14, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                column: "DueDate",
                value: new DateTime(2024, 5, 14, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                column: "DueDate",
                value: new DateTime(2024, 5, 14, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                column: "DueDate",
                value: new DateTime(2024, 5, 14, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                column: "DueDate",
                value: new DateTime(2024, 5, 14, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                column: "DueDate",
                value: new DateTime(2024, 5, 14, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                column: "DueDate",
                value: new DateTime(2024, 5, 14, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "First List");
        }
    }
}
