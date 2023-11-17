using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AluguelDeCarros.Migrations
{
    public partial class addingDmMarcasTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: "990287d0-bbc8-4cf8-8216-7ad67c0d3ad6");

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: "f5d58797-e050-4a7a-9e6b-7842b10f589c");

            migrationBuilder.RenameColumn(
                name: "Marca",
                table: "Carros",
                newName: "MarcaId");

            migrationBuilder.CreateTable(
                name: "DmMarcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(127)", maxLength: 127, nullable: false),
                    Marca = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DmMarcas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DmMarcas",
                columns: new[] { "Id", "Marca", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Volkswagen" },
                    { 2, 2, "Fiat" },
                    { 3, 3, "Chevrolet" },
                    { 4, 4, "Ford" },
                    { 5, 5, "Honda" },
                    { 6, 6, "Suzuki" },
                    { 7, 7, "Toyota" },
                    { 8, 8, "Bmw" },
                    { 9, 9, "Renault" },
                    { 10, 10, "Citroen" },
                    { 11, 11, "Dodge" },
                    { 12, 12, "Mercedez" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Cpf", "Email", "Name", "Role", "Senha" },
                values: new object[,]
                {
                    { "15dcb50c-9085-486f-81b5-7563a147c122", null, "ddd@gmail.com", "Rodrigo", null, "123" },
                    { "1735f7c1-561c-4486-b0cf-499133a823e6", null, "adm@gmail.com", "Adm", 2, "123" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carros_MarcaId",
                table: "Carros",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carros_DmMarcas_MarcaId",
                table: "Carros",
                column: "MarcaId",
                principalTable: "DmMarcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carros_DmMarcas_MarcaId",
                table: "Carros");

            migrationBuilder.DropTable(
                name: "DmMarcas");

            migrationBuilder.DropIndex(
                name: "IX_Carros_MarcaId",
                table: "Carros");

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: "15dcb50c-9085-486f-81b5-7563a147c122");

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: "1735f7c1-561c-4486-b0cf-499133a823e6");

            migrationBuilder.RenameColumn(
                name: "MarcaId",
                table: "Carros",
                newName: "Marca");

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Cpf", "Email", "Name", "Role", "Senha" },
                values: new object[] { "990287d0-bbc8-4cf8-8216-7ad67c0d3ad6", null, "adm@gmail.com", "Adm", 2, "123" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Cpf", "Email", "Name", "Role", "Senha" },
                values: new object[] { "f5d58797-e050-4a7a-9e6b-7842b10f589c", null, "ddd@gmail.com", "Rodrigo", null, "123" });
        }
    }
}
