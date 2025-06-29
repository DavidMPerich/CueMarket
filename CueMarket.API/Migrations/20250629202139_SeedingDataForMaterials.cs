using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CueMarket.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataForMaterials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("07821949-63ea-4acb-8c40-4080782cc882"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("099c4071-c437-4c10-9e53-0cda84fcf724"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("347e299a-9323-4005-b63f-48323e4c803b"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("4dea9573-501b-4d95-a9df-1ba18a667df7"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("f41fd147-9a1d-437f-852a-6d38fc704c5b"));

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("3ba8cfa2-f0cd-4e7a-97e7-9223b0477802"), "Ash", "Wood" },
                    { new Guid("50606191-d2ca-44a7-83f4-4565bd2aa499"), "Bamboo", "Wood" },
                    { new Guid("557f813b-8356-4b2f-94e0-c2e2a9e836fb"), "Maple", "Wood" },
                    { new Guid("8a8aa096-bbf2-4fc9-a1e1-f412fbe1debc"), "Phenolic", "Synthetic" },
                    { new Guid("9f055de2-bb46-434e-801f-b8bc1e59005b"), "Stainless Steel", "Metal" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("3ba8cfa2-f0cd-4e7a-97e7-9223b0477802"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("50606191-d2ca-44a7-83f4-4565bd2aa499"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("557f813b-8356-4b2f-94e0-c2e2a9e836fb"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("8a8aa096-bbf2-4fc9-a1e1-f412fbe1debc"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("9f055de2-bb46-434e-801f-b8bc1e59005b"));

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("07821949-63ea-4acb-8c40-4080782cc882"), "Maple", "Wood" },
                    { new Guid("099c4071-c437-4c10-9e53-0cda84fcf724"), "Ash", "Wood" },
                    { new Guid("347e299a-9323-4005-b63f-48323e4c803b"), "Bamboo", "Wood" },
                    { new Guid("4dea9573-501b-4d95-a9df-1ba18a667df7"), "Stainless Steel", "Metal" },
                    { new Guid("f41fd147-9a1d-437f-852a-6d38fc704c5b"), "Phenolic", "Synthetic" }
                });
        }
    }
}
