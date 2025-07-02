using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CueMarket.API.Migrations
{
    /// <inheritdoc />
    public partial class MakeButtFieldsNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Butts_Bumpers_BumperId",
                table: "Butts");

            migrationBuilder.DropForeignKey(
                name: "FK_Butts_ButtSleeves_ButtSleeveId",
                table: "Butts");

            migrationBuilder.DropForeignKey(
                name: "FK_Butts_Forearms_ForearmId",
                table: "Butts");

            migrationBuilder.DropForeignKey(
                name: "FK_Butts_Materials_ButtCapMaterialId",
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

            migrationBuilder.AlterColumn<Guid>(
                name: "WrapId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "WeightBoltId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "RingEId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "RingDId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "RingCId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "RingBId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ForearmId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CollarMaterialId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ButtSleeveId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ButtCapMaterialId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "BumperId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Bumpers_BumperId",
                table: "Butts",
                column: "BumperId",
                principalTable: "Bumpers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_ButtSleeves_ButtSleeveId",
                table: "Butts",
                column: "ButtSleeveId",
                principalTable: "ButtSleeves",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Forearms_ForearmId",
                table: "Butts",
                column: "ForearmId",
                principalTable: "Forearms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Materials_ButtCapMaterialId",
                table: "Butts",
                column: "ButtCapMaterialId",
                principalTable: "Materials",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Materials_CollarMaterialId",
                table: "Butts",
                column: "CollarMaterialId",
                principalTable: "Materials",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Rings_RingBId",
                table: "Butts",
                column: "RingBId",
                principalTable: "Rings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Rings_RingCId",
                table: "Butts",
                column: "RingCId",
                principalTable: "Rings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Rings_RingDId",
                table: "Butts",
                column: "RingDId",
                principalTable: "Rings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Rings_RingEId",
                table: "Butts",
                column: "RingEId",
                principalTable: "Rings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_WeightBolts_WeightBoltId",
                table: "Butts",
                column: "WeightBoltId",
                principalTable: "WeightBolts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Wraps_WrapId",
                table: "Butts",
                column: "WrapId",
                principalTable: "Wraps",
                principalColumn: "Id");
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
                name: "FK_Butts_Forearms_ForearmId",
                table: "Butts");

            migrationBuilder.DropForeignKey(
                name: "FK_Butts_Materials_ButtCapMaterialId",
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

            migrationBuilder.AlterColumn<Guid>(
                name: "WrapId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "WeightBoltId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RingEId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RingDId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RingCId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RingBId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ForearmId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CollarMaterialId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ButtSleeveId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ButtCapMaterialId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "BumperId",
                table: "Butts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Bumpers_BumperId",
                table: "Butts",
                column: "BumperId",
                principalTable: "Bumpers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_ButtSleeves_ButtSleeveId",
                table: "Butts",
                column: "ButtSleeveId",
                principalTable: "ButtSleeves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Forearms_ForearmId",
                table: "Butts",
                column: "ForearmId",
                principalTable: "Forearms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Materials_ButtCapMaterialId",
                table: "Butts",
                column: "ButtCapMaterialId",
                principalTable: "Materials",
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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Rings_RingCId",
                table: "Butts",
                column: "RingCId",
                principalTable: "Rings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Rings_RingDId",
                table: "Butts",
                column: "RingDId",
                principalTable: "Rings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Rings_RingEId",
                table: "Butts",
                column: "RingEId",
                principalTable: "Rings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_WeightBolts_WeightBoltId",
                table: "Butts",
                column: "WeightBoltId",
                principalTable: "WeightBolts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Butts_Wraps_WrapId",
                table: "Butts",
                column: "WrapId",
                principalTable: "Wraps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
