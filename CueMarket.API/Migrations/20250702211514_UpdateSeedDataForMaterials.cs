using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CueMarket.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedDataForMaterials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("0df02a5b-25fc-4853-85e9-bc5ee1dffff6"), "Juma", "Collar" },
                    { new Guid("12be0d93-1034-489c-9a68-79e7911c9d99"), "Cocobolo", "Collar" },
                    { new Guid("60369fa0-2a8f-4f1d-aeea-96ced38a9053"), "G10", "Collar" },
                    { new Guid("61896bf6-3504-4901-9586-e22ad63efcd6"), "Aegis", "Collar" },
                    { new Guid("74af0241-a897-4b36-977d-47c7a98fd64f"), "Ivory", "Collar" },
                    { new Guid("810ee629-2325-4778-9781-b9c25f73a41d"), "Stainless Steel", "Collar" },
                    { new Guid("894c52fb-f5a0-41f8-8443-984a71ca1c0a"), "Phenolic Resin", "Collar" },
                    { new Guid("9e7cfed7-3e01-470a-9869-e0a7f2ec5e62"), "ABS Plastic", "Collar" },
                    { new Guid("b958c135-27eb-4b86-8115-cb06eebf0f55"), "Brass", "Collar" },
                    { new Guid("d1e339a1-246f-4099-93b1-4b9d7abb1c6c"), "Micarta", "Collar" },
                    { new Guid("d367b855-4137-4e82-ae40-57efe4b4e21e"), "Ebony", "Collar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("0df02a5b-25fc-4853-85e9-bc5ee1dffff6"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("12be0d93-1034-489c-9a68-79e7911c9d99"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("60369fa0-2a8f-4f1d-aeea-96ced38a9053"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("61896bf6-3504-4901-9586-e22ad63efcd6"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("74af0241-a897-4b36-977d-47c7a98fd64f"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("810ee629-2325-4778-9781-b9c25f73a41d"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("894c52fb-f5a0-41f8-8443-984a71ca1c0a"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("9e7cfed7-3e01-470a-9869-e0a7f2ec5e62"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("b958c135-27eb-4b86-8115-cb06eebf0f55"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("d1e339a1-246f-4099-93b1-4b9d7abb1c6c"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("d367b855-4137-4e82-ae40-57efe4b4e21e"));
        }
    }
}
