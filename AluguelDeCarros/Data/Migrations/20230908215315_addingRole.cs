using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AluguelDeCarros.Migrations
{
    public partial class addingRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Usuario",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Usuario",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Cpf", "Email", "Name", "Role" },
                values: new object[] { 1, null, "ddd@gmail.com", "Rodrigo", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Usuario");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Usuario",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldNullable: true);
        }
    }
}
