using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CueMarket.API.Migrations
{
    /// <inheritdoc />
    public partial class FixButtCapMaterialSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("49ecccb1-096a-4796-b791-a9defd95595c"),
                column: "Type",
                value: "ButtCap");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("8a37c59e-c72b-4eba-b54c-f1a768c4ec1a"),
                column: "Type",
                value: "ButtCap");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("96257cdf-5810-45d9-b0cb-aa8d1570063f"),
                column: "Type",
                value: "ButtCap");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("49ecccb1-096a-4796-b791-a9defd95595c"),
                column: "Type",
                value: "Collar");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("8a37c59e-c72b-4eba-b54c-f1a768c4ec1a"),
                column: "Type",
                value: "Collar");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("96257cdf-5810-45d9-b0cb-aa8d1570063f"),
                column: "Type",
                value: "Collar");
        }
    }
}
