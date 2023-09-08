using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AluguelDeCarros.Migrations
{
    public partial class JustSomeChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmUso",
                table: "Carros");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EmUso",
                table: "Carros",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
