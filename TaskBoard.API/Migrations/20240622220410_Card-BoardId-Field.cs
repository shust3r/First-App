using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskBoard.API.Migrations
{
    /// <inheritdoc />
    public partial class CardBoardIdField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BoardId",
                table: "Cards",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CardName", "OperationDate", "ValueAfter" },
                values: new object[] { "Make Interesting Card", new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5784), "Make Interesting Card" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CardName", "OperationDate", "ValueAfter" },
                values: new object[] { "Make Tests", new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5787), "Make Tests" });

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
                columns: new[] { "CardName", "ListId", "ListName", "OperationDate", "ValueAfter" },
                values: new object[] { "Patch the card", 2, "Code", new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5791), "Patch the card" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CardName", "ListName", "OperationDate", "ValueAfter" },
                values: new object[] { "Clean the code", "Code", new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5792), "Clean the code" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CardName", "ListName", "OperationDate", "ValueAfter" },
                values: new object[] { "Card 8", "Code", new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5794), "Card 8" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CardName", "ListId", "ListName", "OperationDate", "ValueAfter" },
                values: new object[] { "Dance with a cat", 3, "Not quite yet", new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5795), "Dance with a cat" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CardName", "ListId", "ListName", "OperationDate", "ValueAfter" },
                values: new object[] { "Summon undead", 3, "Not quite yet", new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5796), "Summon undead" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CardName", "ListId", "ListName", "OperationDate", "ValueAfter" },
                values: new object[] { "Conquer the world", 3, "Not quite yet", new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5798), "Conquer the world" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CardName", "ListId", "ListName", "OperationDate", "ValueAfter" },
                values: new object[] { "Do something", 4, "Some other stuff", new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5799), "Do something" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ListName", "OperationDate" },
                values: new object[] { "Some other stuff", new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CardName", "ListName", "OperationDate", "ValueAfter" },
                values: new object[] { "Fix the Activity UI", "Some other stuff", new DateTime(2024, 6, 22, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5802), "Fix the Activity UI" });

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Main Board");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BoardId", "Description", "DueDate", "Name" },
                values: new object[] { 1, "Some Interesting description", new DateTime(2024, 6, 24, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5699), "Make Interesting Card" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BoardId", "Description", "DueDate", "Name" },
                values: new object[] { 1, "Testers want to sleep...", new DateTime(2024, 6, 24, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5709), "Make Tests" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BoardId", "DueDate" },
                values: new object[] { 1, new DateTime(2024, 6, 24, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BoardId", "DueDate" },
                values: new object[] { 1, new DateTime(2024, 6, 23, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BoardId", "Description", "DueDate", "ListId", "Name", "Priority" },
                values: new object[] { 1, "Try to Patch the card with ID 13.", new DateTime(2024, 6, 23, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5716), 2, "Patch the card", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BoardId", "Description", "DueDate", "Name", "Priority" },
                values: new object[] { 1, "Clean ALL the insufficient code before commit", new DateTime(2024, 6, 26, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5718), "Clean the code", 1 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BoardId", "DueDate", "Name", "Priority" },
                values: new object[] { 1, new DateTime(2024, 6, 26, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5720), "Card 8", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BoardId", "Description", "DueDate", "ListId", "Name", "Priority" },
                values: new object[] { 1, "Make an ritual dance with a cat", new DateTime(2024, 6, 27, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5722), 3, "Dance with a cat", 1 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BoardId", "Description", "DueDate", "ListId", "Name", "Priority" },
                values: new object[] { 1, "Summon the undead warrior to defend your planet", new DateTime(2024, 6, 27, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5724), 3, "Summon undead", 1 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BoardId", "Description", "DueDate", "ListId", "Name" },
                values: new object[] { 1, "Make undesputable dominance over your world.", new DateTime(2024, 6, 25, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5726), 3, "Conquer the world" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BoardId", "DueDate", "ListId", "Name", "Priority" },
                values: new object[] { 1, new DateTime(2024, 6, 23, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5728), 4, "Do something", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BoardId", "DueDate", "Priority" },
                values: new object[] { 1, new DateTime(2024, 6, 26, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5730), 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BoardId", "DueDate", "Name" },
                values: new object[] { 1, new DateTime(2024, 6, 26, 22, 4, 9, 706, DateTimeKind.Utc).AddTicks(5732), "Fix the Activity UI" });

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Code");

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Not quite yet");

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Some other stuff");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BoardId",
                table: "Cards");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CardName", "OperationDate", "ValueAfter" },
                values: new object[] { "Card Name 1", new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4132), "Card Name 1" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CardName", "OperationDate", "ValueAfter" },
                values: new object[] { "Card 2", new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4135), "Card 2" });

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
                columns: new[] { "CardName", "ListId", "ListName", "OperationDate", "ValueAfter" },
                values: new object[] { "Card Name 5", 1, "Urgent", new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4140), "Card Name 5" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CardName", "ListName", "OperationDate", "ValueAfter" },
                values: new object[] { "Card 6", "Second List", new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4141), "Card 6" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CardName", "ListName", "OperationDate", "ValueAfter" },
                values: new object[] { "Card Name 7", "Second List", new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4143), "Card Name 7" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CardName", "ListId", "ListName", "OperationDate", "ValueAfter" },
                values: new object[] { "Card 8", 2, "Second List", new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4144), "Card 8" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CardName", "ListId", "ListName", "OperationDate", "ValueAfter" },
                values: new object[] { "Card Name 9", 2, "Second List", new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4146), "Card Name 9" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CardName", "ListId", "ListName", "OperationDate", "ValueAfter" },
                values: new object[] { "Card 10", 2, "Second List", new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4147), "Card 10" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CardName", "ListId", "ListName", "OperationDate", "ValueAfter" },
                values: new object[] { "Card 11", 3, "Third List", new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4149), "Card 11" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ListName", "OperationDate" },
                values: new object[] { "Fourth List", new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CardName", "ListName", "OperationDate", "ValueAfter" },
                values: new object[] { "Card Name 13", "Fourth List", new DateTime(2024, 5, 23, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4151), "Fix Activity UI" });

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "First Board");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "DueDate", "Name" },
                values: new object[] { "Task description should be unambiguous, accurate, factual.", new DateTime(2024, 5, 25, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4043), "Card Name 1" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "DueDate", "Name" },
                values: new object[] { "Task description should be unambiguous, accurate, factual.", new DateTime(2024, 5, 25, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4063), "Card 2" });

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
                columns: new[] { "Description", "DueDate", "ListId", "Name", "Priority" },
                values: new object[] { "Task description should be unambiguous, accurate, factual.", new DateTime(2024, 5, 24, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4070), 1, "Card Name 5", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "DueDate", "Name", "Priority" },
                values: new object[] { "Task description should be unambiguous, accurate, factual.", new DateTime(2024, 5, 24, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4071), "Card 6", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DueDate", "Name", "Priority" },
                values: new object[] { new DateTime(2024, 5, 27, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4073), "Card Name 7", 1 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "DueDate", "ListId", "Name", "Priority" },
                values: new object[] { "Task description should be unambiguous, accurate, factual.", new DateTime(2024, 5, 27, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4075), 2, "Card 8", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "DueDate", "ListId", "Name", "Priority" },
                values: new object[] { "Task description should be unambiguous, accurate, factual.", new DateTime(2024, 5, 27, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4077), 2, "Card Name 9", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "DueDate", "ListId", "Name" },
                values: new object[] { "Task description should be unambiguous, accurate, factual.", new DateTime(2024, 5, 27, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4079), 2, "Card 10" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DueDate", "ListId", "Name", "Priority" },
                values: new object[] { new DateTime(2024, 5, 28, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4080), 3, "Card 11", 1 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DueDate", "Priority" },
                values: new object[] { new DateTime(2024, 5, 28, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4082), 1 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DueDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 38, 25, 555, DateTimeKind.Utc).AddTicks(4084), "Card 13" });

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Second List");

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Third List");

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Fourth List");
        }
    }
}
