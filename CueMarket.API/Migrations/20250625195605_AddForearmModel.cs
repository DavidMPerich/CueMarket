using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CueMarket.API.Migrations
{
    /// <inheritdoc />
    public partial class AddForearmModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CollarMaterialId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ForearmId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RingBId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RingCId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Forearms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Design = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forearms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Forearms_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Butts_CollarMaterialId",
                table: "Butts",
                column: "CollarMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Butts_ForearmId",
                table: "Butts",
                column: "ForearmId");

            migrationBuilder.CreateIndex(
                name: "IX_Butts_RingBId",
                table: "Butts",
                column: "RingBId");

            migrationBuilder.CreateIndex(
                name: "IX_Butts_RingCId",
                table: "Butts",
                column: "RingCId");

            migrationBuilder.CreateIndex(
                name: "IX_Forearms_MaterialId",
                table: "Forearms",
                column: "MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Forearms_ForearmId",
                table: "Butts",
                column: "ForearmId",
                principalTable: "Forearms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Materials_CollarMaterialId",
                table: "Butts",
                column: "CollarMaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Rings_RingBId",
                table: "Butts",
                column: "RingBId",
                principalTable: "Rings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Rings_RingCId",
                table: "Butts",
                column: "RingCId",
                principalTable: "Rings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Butts_Forearms_ForearmId",
                table: "Butts");

            migrationBuilder.DropForeignKey(
                name: "FK_Butts_Materials_CollarMaterialId",
                table: "Butts");

            migrationBuilder.DropForeignKey(
                name: "FK_Butts_Rings_RingBId",
                table: "Butts");

            migrationBuilder.DropForeignKey(
                name: "FK_Butts_Rings_RingCId",
                table: "Butts");

            migrationBuilder.DropTable(
                name: "Forearms");

            migrationBuilder.DropIndex(
                name: "IX_Butts_CollarMaterialId",
                table: "Butts");

            migrationBuilder.DropIndex(
                name: "IX_Butts_ForearmId",
                table: "Butts");

            migrationBuilder.DropIndex(
                name: "IX_Butts_RingBId",
                table: "Butts");

            migrationBuilder.DropIndex(
                name: "IX_Butts_RingCId",
                table: "Butts");

            migrationBuilder.DropColumn(
                name: "CollarMaterialId",
                table: "Butts");

            migrationBuilder.DropColumn(
                name: "ForearmId",
                table: "Butts");

            migrationBuilder.DropColumn(
                name: "RingBId",
                table: "Butts");

            migrationBuilder.DropColumn(
                name: "RingCId",
                table: "Butts");
        }
    }
}
