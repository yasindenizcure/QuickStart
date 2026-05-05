using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuickStartWebApi.Migrations
{
    /// <inheritdoc />
    public partial class opt1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Options1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Options2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Options1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Options2",
                table: "Abouts");
        }
    }
}
