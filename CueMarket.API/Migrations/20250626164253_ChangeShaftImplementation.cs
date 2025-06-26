using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CueMarket.API.Migrations
{
    /// <inheritdoc />
    public partial class ChangeShaftImplementation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cues_Shafts_ShaftAId",
                table: "Cues");

            migrationBuilder.DropForeignKey(
                name: "FK_Cues_Shafts_ShaftBId",
                table: "Cues");

            migrationBuilder.DropForeignKey(
                name: "FK_Cues_Shafts_ShaftCId",
                table: "Cues");

            migrationBuilder.DropForeignKey(
                name: "FK_Cues_Shafts_ShaftDId",
                table: "Cues");

            migrationBuilder.DropForeignKey(
                name: "FK_Cues_Shafts_ShaftEId",
                table: "Cues");

            migrationBuilder.DropIndex(
                name: "IX_Cues_ShaftAId",
                table: "Cues");

            migrationBuilder.DropIndex(
                name: "IX_Cues_ShaftBId",
                table: "Cues");

            migrationBuilder.DropIndex(
                name: "IX_Cues_ShaftCId",
                table: "Cues");

            migrationBuilder.DropIndex(
                name: "IX_Cues_ShaftDId",
                table: "Cues");

            migrationBuilder.DropIndex(
                name: "IX_Cues_ShaftEId",
                table: "Cues");

            migrationBuilder.DropColumn(
                name: "ShaftAId",
                table: "Cues");

            migrationBuilder.DropColumn(
                name: "ShaftBId",
                table: "Cues");

            migrationBuilder.DropColumn(
                name: "ShaftCId",
                table: "Cues");

            migrationBuilder.DropColumn(
                name: "ShaftDId",
                table: "Cues");

            migrationBuilder.DropColumn(
                name: "ShaftEId",
                table: "Cues");

            migrationBuilder.AddColumn<Guid>(
                name: "CueId",
                table: "Shafts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Shafts_CueId",
                table: "Shafts",
                column: "CueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shafts_Cues_CueId",
                table: "Shafts",
                column: "CueId",
                principalTable: "Cues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shafts_Cues_CueId",
                table: "Shafts");

            migrationBuilder.DropIndex(
                name: "IX_Shafts_CueId",
                table: "Shafts");

            migrationBuilder.DropColumn(
                name: "CueId",
                table: "Shafts");

            migrationBuilder.AddColumn<Guid>(
                name: "ShaftAId",
                table: "Cues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ShaftBId",
                table: "Cues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ShaftCId",
                table: "Cues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ShaftDId",
                table: "Cues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ShaftEId",
                table: "Cues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Cues_ShaftAId",
                table: "Cues",
                column: "ShaftAId");

            migrationBuilder.CreateIndex(
                name: "IX_Cues_ShaftBId",
                table: "Cues",
                column: "ShaftBId");

            migrationBuilder.CreateIndex(
                name: "IX_Cues_ShaftCId",
                table: "Cues",
                column: "ShaftCId");

            migrationBuilder.CreateIndex(
                name: "IX_Cues_ShaftDId",
                table: "Cues",
                column: "ShaftDId");

            migrationBuilder.CreateIndex(
                name: "IX_Cues_ShaftEId",
                table: "Cues",
                column: "ShaftEId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cues_Shafts_ShaftAId",
                table: "Cues",
                column: "ShaftAId",
                principalTable: "Shafts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cues_Shafts_ShaftBId",
                table: "Cues",
                column: "ShaftBId",
                principalTable: "Shafts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cues_Shafts_ShaftCId",
                table: "Cues",
                column: "ShaftCId",
                principalTable: "Shafts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cues_Shafts_ShaftDId",
                table: "Cues",
                column: "ShaftDId",
                principalTable: "Shafts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cues_Shafts_ShaftEId",
                table: "Cues",
                column: "ShaftEId",
                principalTable: "Shafts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
