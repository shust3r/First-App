using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskBoard.API.Migrations
{
    /// <inheritdoc />
    public partial class Board_And_Activities_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BoardId",
                table: "Lists",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OperationName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    OperationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ValueBefore = table.Column<string>(type: "text", nullable: false),
                    ValueAfter = table.Column<string>(type: "text", nullable: false),
                    ListId = table.Column<int>(type: "integer", nullable: false),
                    CardId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "CardId", "ListId", "OperationDate", "OperationName", "ValueAfter", "ValueBefore" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(750), "add", "Card Name 1", "" },
                    { 2, 2, 1, new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(752), "add", "Card 2", "" },
                    { 3, 3, 1, new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(753), "add", "Card Name 3", "" },
                    { 4, 4, 1, new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(754), "add", "Card 4", "" },
                    { 5, 5, 1, new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(756), "add", "Card Name 5", "" },
                    { 6, 6, 2, new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(757), "add", "Card 6", "" },
                    { 7, 7, 2, new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(758), "add", "Card Name 7", "" },
                    { 8, 8, 2, new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(760), "add", "Card 8", "" },
                    { 9, 9, 2, new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(761), "add", "Card Name 9", "" },
                    { 10, 10, 2, new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(762), "add", "Card 10", "" },
                    { 11, 11, 3, new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(763), "add", "Card 11", "" },
                    { 12, 12, 4, new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(765), "add", "Card 12", "" },
                    { 13, 13, 4, new DateTime(2024, 5, 13, 19, 48, 24, 369, DateTimeKind.Utc).AddTicks(766), "add", "Card 13", "" }
                });

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "First Board" });

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
                column: "BoardId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 2,
                column: "BoardId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 3,
                column: "BoardId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 4,
                column: "BoardId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Lists_BoardId",
                table: "Lists",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_CardId",
                table: "Activities",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lists_Boards_BoardId",
                table: "Lists",
                column: "BoardId",
                principalTable: "Boards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lists_Boards_BoardId",
                table: "Lists");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Boards");

            migrationBuilder.DropIndex(
                name: "IX_Lists_BoardId",
                table: "Lists");

            migrationBuilder.DropColumn(
                name: "BoardId",
                table: "Lists");

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

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                column: "DueDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                column: "DueDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                column: "DueDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
