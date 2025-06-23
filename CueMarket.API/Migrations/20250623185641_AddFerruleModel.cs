using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CueMarket.API.Migrations
{
    /// <inheritdoc />
    public partial class AddFerruleModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FerruleId",
                table: "Shafts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Ferrules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Capped = table.Column<bool>(type: "bit", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ferrules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ferrules_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shafts_FerruleId",
                table: "Shafts",
                column: "FerruleId");

            migrationBuilder.CreateIndex(
                name: "IX_Ferrules_MaterialId",
                table: "Ferrules",
                column: "MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shafts_Ferrules_FerruleId",
                table: "Shafts",
                column: "FerruleId",
                principalTable: "Ferrules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shafts_Ferrules_FerruleId",
                table: "Shafts");

            migrationBuilder.DropTable(
                name: "Ferrules");

            migrationBuilder.DropIndex(
                name: "IX_Shafts_FerruleId",
                table: "Shafts");

            migrationBuilder.DropColumn(
                name: "FerruleId",
                table: "Shafts");
        }
    }
}
