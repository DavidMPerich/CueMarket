using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CueMarket.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedDataForMaterialsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("04215709-e8e9-4f52-adaf-8d71c4ed80bd"), "Leather (Hard)", "Tip" },
                    { new Guid("0856a0fe-8c7c-4647-8604-02648c476ffe"), "Bocote", "Forearm" },
                    { new Guid("0b0ece71-056b-4b73-9a36-aaf71229679c"), "Leather", "Wrap" },
                    { new Guid("11cfbe35-cf6d-4d10-b14c-759c58b325db"), "No Wrap (Sanded Wood)", "Wrap" },
                    { new Guid("145f9e1b-7f2f-40b9-9a2f-b5a922b8b0b7"), "Zebrawood", "Forearm" },
                    { new Guid("1aacb15a-b175-4bc9-8906-6c9bd924d501"), "Phenolic", "Tip" },
                    { new Guid("25199d2e-f4d8-4a4a-9903-119062f13802"), "Maple", "Shaft" },
                    { new Guid("25fbe48b-c7ac-40d1-a321-c104d28dd801"), "Phenolic Resin", "Ring" },
                    { new Guid("318c3630-59ea-4ab0-bc11-7682158e8187"), "Fiber", "Ferrule" },
                    { new Guid("3403b28a-0872-4d9b-811a-bb2aabaaa134"), "Ash", "Shaft" },
                    { new Guid("470b32e0-dd66-4e81-b00f-da49141186cc"), "Boar Hide", "Tip" },
                    { new Guid("4ce5bead-a405-4e85-912e-220d2b3b86b1"), "Juma", "Ferrule" },
                    { new Guid("51969122-92e7-4330-8f44-0758259f4e57"), "Snakewood", "Forearm" },
                    { new Guid("51e48532-da6c-4800-aaec-54c9f47157ee"), "Curly Maple", "Forearm" },
                    { new Guid("64b64d9e-74df-4e28-8cb3-8b7dc1bb5759"), "Ivorine", "Ferrule" },
                    { new Guid("77313c18-88ff-4a29-ba07-26d93d38179b"), "Lizard Skin", "Wrap" },
                    { new Guid("7b74a27e-2ecd-4de7-8f80-067a1e554668"), "Wood Veneer", "Ring" },
                    { new Guid("813b53bb-f442-4282-9d4d-030733c91929"), "Phenolic Resin", "Ferrule" },
                    { new Guid("8e7f04d4-ae1e-4525-8772-f002021f3076"), "Carbon Fiber", "Shaft" },
                    { new Guid("8ef1b81a-f23c-48be-b3f9-2dc109ccaa9d"), "Micarta", "Ring" },
                    { new Guid("90f33c74-1d57-4fac-b510-cab28655893f"), "Layered Leather", "Tip" },
                    { new Guid("95b70cc1-18de-4b93-94b2-d1a9f878a2a3"), "Aegis", "Ferrule" },
                    { new Guid("9f4d1f5b-aec7-4268-b9fd-a6e38dec3893"), "Leather (Medium)", "Tip" },
                    { new Guid("a295444f-98b0-46a3-9909-3c4bb9decc54"), "Fiberglass", "Shaft" },
                    { new Guid("a57c62b2-d8de-487e-9fb3-4d9ab475f3ba"), "Silver", "Ring" },
                    { new Guid("a6d87bc6-8ef2-4bd2-99e3-9b0b80d48224"), "Purpleheart", "Forearm" },
                    { new Guid("ac7b4058-3cc6-461e-aec6-93d10d7a32f0"), "Irish Linen", "Wrap" },
                    { new Guid("b01e022a-19b5-45bd-91b9-0aa16b0fe5cd"), "Ivory", "Ring" },
                    { new Guid("c77082af-4d1c-4aa7-887b-ee013676963a"), "Rosewood", "Forearm" },
                    { new Guid("c92a68b7-0578-497b-8675-281983e9de79"), "Linen Melamine", "Ferrule" },
                    { new Guid("d3522b74-6896-43a1-9775-0124c5f5c115"), "Brass", "Ring" },
                    { new Guid("d662a7bf-adaf-41c8-9ded-3347dac55bc4"), "Ivory", "Ferrule" },
                    { new Guid("da3eaf67-5282-41aa-9f16-b33637648f46"), "Cocobolo", "Forearm" },
                    { new Guid("dff167ba-ae2b-450f-adc9-860581185607"), "Silicone Grip", "Wrap" },
                    { new Guid("e18e0c18-0e88-4f46-b375-f1afcd6f7052"), "Birdseye Maple", "Forearm" },
                    { new Guid("e1e8987d-9ae5-45d4-8051-e11213494f59"), "Maple", "Forearm" },
                    { new Guid("eb056bbc-ff3f-479c-8595-eae1233a59e4"), "Rubber", "Wrap" },
                    { new Guid("f1b2ac72-454e-41d1-98ce-c1ce68ccf3b4"), "Nickel", "Ring" },
                    { new Guid("f86e0b8c-eafa-465c-a2fc-8c4fd73a8cfd"), "Leather (Soft)", "Tip" },
                    { new Guid("fc409b0a-7b22-47a2-8068-4ae3c2c06ae0"), "Ebony", "Forearm" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("04215709-e8e9-4f52-adaf-8d71c4ed80bd"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("0856a0fe-8c7c-4647-8604-02648c476ffe"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("0b0ece71-056b-4b73-9a36-aaf71229679c"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("11cfbe35-cf6d-4d10-b14c-759c58b325db"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("145f9e1b-7f2f-40b9-9a2f-b5a922b8b0b7"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("1aacb15a-b175-4bc9-8906-6c9bd924d501"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("25199d2e-f4d8-4a4a-9903-119062f13802"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("25fbe48b-c7ac-40d1-a321-c104d28dd801"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("318c3630-59ea-4ab0-bc11-7682158e8187"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("3403b28a-0872-4d9b-811a-bb2aabaaa134"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("470b32e0-dd66-4e81-b00f-da49141186cc"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("4ce5bead-a405-4e85-912e-220d2b3b86b1"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("51969122-92e7-4330-8f44-0758259f4e57"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("51e48532-da6c-4800-aaec-54c9f47157ee"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("64b64d9e-74df-4e28-8cb3-8b7dc1bb5759"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("77313c18-88ff-4a29-ba07-26d93d38179b"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("7b74a27e-2ecd-4de7-8f80-067a1e554668"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("813b53bb-f442-4282-9d4d-030733c91929"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("8e7f04d4-ae1e-4525-8772-f002021f3076"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("8ef1b81a-f23c-48be-b3f9-2dc109ccaa9d"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("90f33c74-1d57-4fac-b510-cab28655893f"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("95b70cc1-18de-4b93-94b2-d1a9f878a2a3"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("9f4d1f5b-aec7-4268-b9fd-a6e38dec3893"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("a295444f-98b0-46a3-9909-3c4bb9decc54"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("a57c62b2-d8de-487e-9fb3-4d9ab475f3ba"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("a6d87bc6-8ef2-4bd2-99e3-9b0b80d48224"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("ac7b4058-3cc6-461e-aec6-93d10d7a32f0"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("b01e022a-19b5-45bd-91b9-0aa16b0fe5cd"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("c77082af-4d1c-4aa7-887b-ee013676963a"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("c92a68b7-0578-497b-8675-281983e9de79"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("d3522b74-6896-43a1-9775-0124c5f5c115"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("d662a7bf-adaf-41c8-9ded-3347dac55bc4"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("da3eaf67-5282-41aa-9f16-b33637648f46"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("dff167ba-ae2b-450f-adc9-860581185607"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("e18e0c18-0e88-4f46-b375-f1afcd6f7052"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("e1e8987d-9ae5-45d4-8051-e11213494f59"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("eb056bbc-ff3f-479c-8595-eae1233a59e4"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("f1b2ac72-454e-41d1-98ce-c1ce68ccf3b4"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("f86e0b8c-eafa-465c-a2fc-8c4fd73a8cfd"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("fc409b0a-7b22-47a2-8068-4ae3c2c06ae0"));

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
    }
}
