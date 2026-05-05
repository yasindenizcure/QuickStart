using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuickStartWebApi.Migrations
{
    /// <inheritdoc />
    public partial class FeatureUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "MainDescription",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "SubDescription",
                table: "Features");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Features",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Features");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Features",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainDescription",
                table: "Features",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubDescription",
                table: "Features",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
