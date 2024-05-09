using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskBoard.API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "character varying(400)", maxLength: 400, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    ListId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Lists_ListId",
                        column: x => x.ListId,
                        principalTable: "Lists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Lists",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "First List" },
                    { 2, "Second List" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Description", "ListId", "ModifiedDate", "Name", "Priority" },
                values: new object[,]
                {
                    { 1, "Task description should be unambiguous, accurate, factual.", 1, new DateTime(2024, 4, 29, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7767), "Card Name 1", 1 },
                    { 2, "Task description should be unambiguous, accurate, factual.", 1, new DateTime(2024, 4, 30, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7775), "Card 2", 2 },
                    { 3, "Task description should be unambiguous, accurate, factual.", 1, new DateTime(2024, 5, 1, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7776), "Card Name 3", 3 },
                    { 4, "Task description should be unambiguous, accurate, factual.", 1, new DateTime(2024, 5, 2, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7778), "Card 4", 1 },
                    { 5, "Task description should be unambiguous, accurate, factual.", 1, new DateTime(2024, 5, 3, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7779), "Card Name 5", 2 },
                    { 6, "Task description should be unambiguous, accurate, factual.", 2, new DateTime(2024, 5, 4, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7781), "Card 6", 3 },
                    { 7, "Task description should be unambiguous, accurate, factual.", 2, new DateTime(2024, 5, 5, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7782), "Card Name 7", 1 },
                    { 8, "Task description should be unambiguous, accurate, factual.", 2, new DateTime(2024, 5, 6, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7783), "Card 8", 2 },
                    { 9, "Task description should be unambiguous, accurate, factual.", 2, new DateTime(2024, 5, 7, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7784), "Card Name 9", 3 },
                    { 10, "Task description should be unambiguous, accurate, factual.", 2, new DateTime(2024, 5, 8, 12, 47, 43, 394, DateTimeKind.Utc).AddTicks(7786), "Card 10", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_ListId",
                table: "Cards",
                column: "ListId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Lists");
        }
    }
}
