using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AluguelDeCarros.Migrations
{
    public partial class adqeopkqokpewqopkeq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: "15dcb50c-9085-486f-81b5-7563a147c122");

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: "1735f7c1-561c-4486-b0cf-499133a823e6");

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Cpf", "Email", "Name", "Role", "Senha" },
                values: new object[] { "525788ef-77ef-4f60-b104-bb9c03096829", null, "ddd@gmail.com", "Rodrigo", null, "123" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Cpf", "Email", "Name", "Role", "Senha" },
                values: new object[] { "67ed01d1-0032-4587-93c6-2d083329384f", null, "adm@gmail.com", "Adm", 2, "123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: "525788ef-77ef-4f60-b104-bb9c03096829");

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: "67ed01d1-0032-4587-93c6-2d083329384f");

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Cpf", "Email", "Name", "Role", "Senha" },
                values: new object[] { "15dcb50c-9085-486f-81b5-7563a147c122", null, "ddd@gmail.com", "Rodrigo", null, "123" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Cpf", "Email", "Name", "Role", "Senha" },
                values: new object[] { "1735f7c1-561c-4486-b0cf-499133a823e6", null, "adm@gmail.com", "Adm", 2, "123" });
        }
    }
}
