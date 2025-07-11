﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CueMarket.API.Migrations
{
    /// <inheritdoc />
    public partial class MakeButtNullableAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cues_Butts_ButtId",
                table: "Cues");

            migrationBuilder.AlterColumn<Guid>(
                name: "ButtId",
                table: "Cues",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Cues_Butts_ButtId",
                table: "Cues",
                column: "ButtId",
                principalTable: "Butts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cues_Butts_ButtId",
                table: "Cues");

            migrationBuilder.AlterColumn<Guid>(
                name: "ButtId",
                table: "Cues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cues_Butts_ButtId",
                table: "Cues",
                column: "ButtId",
                principalTable: "Butts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
