using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CueMarket.API.Migrations
{
    /// <inheritdoc />
    public partial class AddRingModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Brand",
                table: "Shafts",
                newName: "Maker");

            migrationBuilder.AddColumn<Guid>(
                name: "RingAId",
                table: "Shafts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Rings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rings_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shafts_RingAId",
                table: "Shafts",
                column: "RingAId");

            migrationBuilder.CreateIndex(
                name: "IX_Rings_MaterialId",
                table: "Rings",
                column: "MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shafts_Rings_RingAId",
                table: "Shafts",
                column: "RingAId",
                principalTable: "Rings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shafts_Rings_RingAId",
                table: "Shafts");

            migrationBuilder.DropTable(
                name: "Rings");

            migrationBuilder.DropIndex(
                name: "IX_Shafts_RingAId",
                table: "Shafts");

            migrationBuilder.DropColumn(
                name: "RingAId",
                table: "Shafts");

            migrationBuilder.RenameColumn(
                name: "Maker",
                table: "Shafts",
                newName: "Brand");
        }
    }
}
