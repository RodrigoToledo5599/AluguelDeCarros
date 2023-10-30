using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AluguelDeCarros.Migrations
{
    public partial class FirstOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(127)", maxLength: 127, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(127)", maxLength: 127, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(127)", maxLength: 127, nullable: false),
                    Role = table.Column<int>(type: "int", nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(127)", maxLength: 127, nullable: false),
                    Marca = table.Column<int>(type: "int", nullable: false),
                    Alugado = table.Column<bool>(type: "bit", nullable: false),
                    ValorDia = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carros_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AluguelAtivos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarroId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    CarroPego = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Finalizado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AluguelAtivos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AluguelAtivos_Carros_CarroId",
                        column: x => x.CarroId,
                        principalTable: "Carros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AluguelAtivos_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Carros",
                columns: new[] { "Id", "Alugado", "Marca", "Name", "UsuarioId", "ValorDia" },
                values: new object[,]
                {
                    { 1, false, 3, "Celta", null, 30 },
                    { 2, false, 2, "Uno", null, 30 },
                    { 3, false, 2, "Palio", null, 30 },
                    { 4, false, 4, "Fusion", null, 80 },
                    { 5, false, 10, "C4 Lounge", null, 70 },
                    { 6, false, 5, "Civic lxr", null, 50 },
                    { 7, false, 11, "Dodge Ram", null, 140 },
                    { 8, false, 3, "Corvette C7 Stingray", null, 390 },
                    { 9, false, 12, "C63", null, 200 },
                    { 10, false, 1, "Gol", null, 50 },
                    { 11, false, 7, "Prius", null, 40 },
                    { 12, false, 7, "Corolla 2017", null, 45 },
                    { 13, false, 7, "Yaris", null, 45 },
                    { 14, false, 4, "Ford Gt 2017", null, 500 },
                    { 15, false, 8, "Bmw M8", null, 360 },
                    { 16, false, 9, "Fluence", null, 55 }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Cpf", "Email", "Name", "Role", "Senha" },
                values: new object[,]
                {
                    { 1, null, "ddd@gmail.com", "Rodrigo", null, "123" },
                    { 2, null, "adm@gmail.com", "Adm", 2, "123" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AluguelAtivos_CarroId",
                table: "AluguelAtivos",
                column: "CarroId");

            migrationBuilder.CreateIndex(
                name: "IX_AluguelAtivos_UsuarioId",
                table: "AluguelAtivos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Carros_UsuarioId",
                table: "Carros",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AluguelAtivos");

            migrationBuilder.DropTable(
                name: "Carros");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
