using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CueMarket.API.Migrations
{
    /// <inheritdoc />
    public partial class AddButtCapMaterialToSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("49ecccb1-096a-4796-b791-a9defd95595c"), "ABS Plastic", "Collar" },
                    { new Guid("8a37c59e-c72b-4eba-b54c-f1a768c4ec1a"), "Ivory", "Collar" },
                    { new Guid("96257cdf-5810-45d9-b0cb-aa8d1570063f"), "Stainless Steel", "Collar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("49ecccb1-096a-4796-b791-a9defd95595c"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("8a37c59e-c72b-4eba-b54c-f1a768c4ec1a"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("96257cdf-5810-45d9-b0cb-aa8d1570063f"));
        }
    }
}
