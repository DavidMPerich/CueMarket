using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CueMarket.API.Migrations
{
    /// <inheritdoc />
    public partial class FinishButtAndAddSupportingTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BumperId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ButtCapMaterialId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ButtSleeveId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RingDId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RingEId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "WeightBoltId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "WrapId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Bumpers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Maker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bumpers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ButtSleeves",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Design = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ButtSleeves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeightBolts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Maker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thread = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightBolts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wraps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wraps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wraps_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Butts_BumperId",
                table: "Butts",
                column: "BumperId");

            migrationBuilder.CreateIndex(
                name: "IX_Butts_ButtCapMaterialId",
                table: "Butts",
                column: "ButtCapMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Butts_ButtSleeveId",
                table: "Butts",
                column: "ButtSleeveId");

            migrationBuilder.CreateIndex(
                name: "IX_Butts_RingDId",
                table: "Butts",
                column: "RingDId");

            migrationBuilder.CreateIndex(
                name: "IX_Butts_RingEId",
                table: "Butts",
                column: "RingEId");

            migrationBuilder.CreateIndex(
                name: "IX_Butts_WeightBoltId",
                table: "Butts",
                column: "WeightBoltId");

            migrationBuilder.CreateIndex(
                name: "IX_Butts_WrapId",
                table: "Butts",
                column: "WrapId");

            migrationBuilder.CreateIndex(
                name: "IX_Wraps_MaterialId",
                table: "Wraps",
                column: "MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Bumpers_BumperId",
                table: "Butts",
                column: "BumperId",
                principalTable: "Bumpers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_ButtSleeves_ButtSleeveId",
                table: "Butts",
                column: "ButtSleeveId",
                principalTable: "ButtSleeves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Materials_ButtCapMaterialId",
                table: "Butts",
                column: "ButtCapMaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Rings_RingDId",
                table: "Butts",
                column: "RingDId",
                principalTable: "Rings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Rings_RingEId",
                table: "Butts",
                column: "RingEId",
                principalTable: "Rings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_WeightBolts_WeightBoltId",
                table: "Butts",
                column: "WeightBoltId",
                principalTable: "WeightBolts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Wraps_WrapId",
                table: "Butts",
                column: "WrapId",
                principalTable: "Wraps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Butts_Bumpers_BumperId",
                table: "Butts");

            migrationBuilder.DropForeignKey(
                name: "FK_Butts_ButtSleeves_ButtSleeveId",
                table: "Butts");

            migrationBuilder.DropForeignKey(
                name: "FK_Butts_Materials_ButtCapMaterialId",
                table: "Butts");

            migrationBuilder.DropForeignKey(
                name: "FK_Butts_Rings_RingDId",
                table: "Butts");

            migrationBuilder.DropForeignKey(
                name: "FK_Butts_Rings_RingEId",
                table: "Butts");

            migrationBuilder.DropForeignKey(
                name: "FK_Butts_WeightBolts_WeightBoltId",
                table: "Butts");

            migrationBuilder.DropForeignKey(
                name: "FK_Butts_Wraps_WrapId",
                table: "Butts");

            migrationBuilder.DropTable(
                name: "Bumpers");

            migrationBuilder.DropTable(
                name: "ButtSleeves");

            migrationBuilder.DropTable(
                name: "WeightBolts");

            migrationBuilder.DropTable(
                name: "Wraps");

            migrationBuilder.DropIndex(
                name: "IX_Butts_BumperId",
                table: "Butts");

            migrationBuilder.DropIndex(
                name: "IX_Butts_ButtCapMaterialId",
                table: "Butts");

            migrationBuilder.DropIndex(
                name: "IX_Butts_ButtSleeveId",
                table: "Butts");

            migrationBuilder.DropIndex(
                name: "IX_Butts_RingDId",
                table: "Butts");

            migrationBuilder.DropIndex(
                name: "IX_Butts_RingEId",
                table: "Butts");

            migrationBuilder.DropIndex(
                name: "IX_Butts_WeightBoltId",
                table: "Butts");

            migrationBuilder.DropIndex(
                name: "IX_Butts_WrapId",
                table: "Butts");

            migrationBuilder.DropColumn(
                name: "BumperId",
                table: "Butts");

            migrationBuilder.DropColumn(
                name: "ButtCapMaterialId",
                table: "Butts");

            migrationBuilder.DropColumn(
                name: "ButtSleeveId",
                table: "Butts");

            migrationBuilder.DropColumn(
                name: "RingDId",
                table: "Butts");

            migrationBuilder.DropColumn(
                name: "RingEId",
                table: "Butts");

            migrationBuilder.DropColumn(
                name: "WeightBoltId",
                table: "Butts");

            migrationBuilder.DropColumn(
                name: "WrapId",
                table: "Butts");
        }
    }
}
