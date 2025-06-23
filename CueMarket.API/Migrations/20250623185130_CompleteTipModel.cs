using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CueMarket.API.Migrations
{
    /// <inheritdoc />
    public partial class CompleteTipModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hardness",
                table: "Tips",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Tips",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hardness",
                table: "Tips");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Tips");
        }
    }
}
