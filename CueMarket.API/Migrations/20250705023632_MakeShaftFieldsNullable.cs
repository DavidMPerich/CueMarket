using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CueMarket.API.Migrations
{
    /// <inheritdoc />
    public partial class MakeShaftFieldsNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shafts_Cues_CueId",
                table: "Shafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Shafts_Ferrules_FerruleId",
                table: "Shafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Shafts_Materials_CollarMaterialId",
                table: "Shafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Shafts_Materials_MaterialId",
                table: "Shafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Shafts_Rings_RingAId",
                table: "Shafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Shafts_Tips_TipId",
                table: "Shafts");

            migrationBuilder.AlterColumn<Guid>(
                name: "TipId",
                table: "Shafts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "RingAId",
                table: "Shafts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "MaterialId",
                table: "Shafts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Maker",
                table: "Shafts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "FerruleId",
                table: "Shafts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CueId",
                table: "Shafts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CollarMaterialId",
                table: "Shafts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Shafts_Cues_CueId",
                table: "Shafts",
                column: "CueId",
                principalTable: "Cues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shafts_Ferrules_FerruleId",
                table: "Shafts",
                column: "FerruleId",
                principalTable: "Ferrules",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shafts_Materials_CollarMaterialId",
                table: "Shafts",
                column: "CollarMaterialId",
                principalTable: "Materials",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shafts_Materials_MaterialId",
                table: "Shafts",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shafts_Rings_RingAId",
                table: "Shafts",
                column: "RingAId",
                principalTable: "Rings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shafts_Tips_TipId",
                table: "Shafts",
                column: "TipId",
                principalTable: "Tips",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shafts_Cues_CueId",
                table: "Shafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Shafts_Ferrules_FerruleId",
                table: "Shafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Shafts_Materials_CollarMaterialId",
                table: "Shafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Shafts_Materials_MaterialId",
                table: "Shafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Shafts_Rings_RingAId",
                table: "Shafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Shafts_Tips_TipId",
                table: "Shafts");

            migrationBuilder.AlterColumn<Guid>(
                name: "TipId",
                table: "Shafts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RingAId",
                table: "Shafts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MaterialId",
                table: "Shafts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Maker",
                table: "Shafts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "FerruleId",
                table: "Shafts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CueId",
                table: "Shafts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CollarMaterialId",
                table: "Shafts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Shafts_Cues_CueId",
                table: "Shafts",
                column: "CueId",
                principalTable: "Cues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shafts_Ferrules_FerruleId",
                table: "Shafts",
                column: "FerruleId",
                principalTable: "Ferrules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shafts_Materials_CollarMaterialId",
                table: "Shafts",
                column: "CollarMaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shafts_Materials_MaterialId",
                table: "Shafts",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shafts_Rings_RingAId",
                table: "Shafts",
                column: "RingAId",
                principalTable: "Rings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shafts_Tips_TipId",
                table: "Shafts",
                column: "TipId",
                principalTable: "Tips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
