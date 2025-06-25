using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CueMarket.API.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCollarModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Butts_Collars_CollarId",
                table: "Butts");

            migrationBuilder.DropForeignKey(
                name: "FK_Shafts_Collars_CollarId",
                table: "Shafts");

            migrationBuilder.DropTable(
                name: "Collars");

            migrationBuilder.DropIndex(
                name: "IX_Butts_CollarId",
                table: "Butts");

            migrationBuilder.DropColumn(
                name: "CollarId",
                table: "Butts");

            migrationBuilder.RenameColumn(
                name: "CollarId",
                table: "Shafts",
                newName: "CollarMaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Shafts_CollarId",
                table: "Shafts",
                newName: "IX_Shafts_CollarMaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shafts_Materials_CollarMaterialId",
                table: "Shafts",
                column: "CollarMaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shafts_Materials_CollarMaterialId",
                table: "Shafts");

            migrationBuilder.RenameColumn(
                name: "CollarMaterialId",
                table: "Shafts",
                newName: "CollarId");

            migrationBuilder.RenameIndex(
                name: "IX_Shafts_CollarMaterialId",
                table: "Shafts",
                newName: "IX_Shafts_CollarId");

            migrationBuilder.AddColumn<Guid>(
                name: "CollarId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Collars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Collars_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Butts_CollarId",
                table: "Butts",
                column: "CollarId");

            migrationBuilder.CreateIndex(
                name: "IX_Collars_MaterialId",
                table: "Collars",
                column: "MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Collars_CollarId",
                table: "Butts",
                column: "CollarId",
                principalTable: "Collars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shafts_Collars_CollarId",
                table: "Shafts",
                column: "CollarId",
                principalTable: "Collars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
