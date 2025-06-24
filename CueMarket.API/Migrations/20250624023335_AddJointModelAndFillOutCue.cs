using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CueMarket.API.Migrations
{
    /// <inheritdoc />
    public partial class AddJointModelAndFillOutCue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Brand",
                table: "Cues",
                newName: "Maker");

            migrationBuilder.AddColumn<Guid>(
                name: "ButtId",
                table: "Cues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "JointId",
                table: "Cues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Butts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Butts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Joints",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joints", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cues_ButtId",
                table: "Cues",
                column: "ButtId");

            migrationBuilder.CreateIndex(
                name: "IX_Cues_JointId",
                table: "Cues",
                column: "JointId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cues_Butts_ButtId",
                table: "Cues",
                column: "ButtId",
                principalTable: "Butts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cues_Joints_JointId",
                table: "Cues",
                column: "JointId",
                principalTable: "Joints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cues_Butts_ButtId",
                table: "Cues");

            migrationBuilder.DropForeignKey(
                name: "FK_Cues_Joints_JointId",
                table: "Cues");

            migrationBuilder.DropTable(
                name: "Butts");

            migrationBuilder.DropTable(
                name: "Joints");

            migrationBuilder.DropIndex(
                name: "IX_Cues_ButtId",
                table: "Cues");

            migrationBuilder.DropIndex(
                name: "IX_Cues_JointId",
                table: "Cues");

            migrationBuilder.DropColumn(
                name: "ButtId",
                table: "Cues");

            migrationBuilder.DropColumn(
                name: "JointId",
                table: "Cues");

            migrationBuilder.RenameColumn(
                name: "Maker",
                table: "Cues",
                newName: "Brand");
        }
    }
}
