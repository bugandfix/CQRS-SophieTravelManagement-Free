using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_SophieTravelManagement.Infrastructure.EF.Migrations
{
    /// <inheritdoc />
    public partial class Init_Read : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "TravelerCheckList");

            migrationBuilder.CreateTable(
                name: "TravelerCheckList",
                schema: "TravelerCheckList",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelerCheckList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TravelerItems",
                schema: "TravelerCheckList",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    IsTaken = table.Column<bool>(type: "bit", nullable: false),
                    TravelerCheckListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelerItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelerItems_TravelerCheckList_TravelerCheckListId",
                        column: x => x.TravelerCheckListId,
                        principalSchema: "TravelerCheckList",
                        principalTable: "TravelerCheckList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TravelerItems_TravelerCheckListId",
                schema: "TravelerCheckList",
                table: "TravelerItems",
                column: "TravelerCheckListId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TravelerItems",
                schema: "TravelerCheckList");

            migrationBuilder.DropTable(
                name: "TravelerCheckList",
                schema: "TravelerCheckList");
        }
    }
}
