using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AluguelDeCarros.Migrations
{
    public partial class DataSeedingALittleBit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Carros",
                columns: new[] { "Id", "Marca", "Name", "UsuarioId" },
                values: new object[,]
                {
                    { 1, 3, "Celta", null },
                    { 2, 2, "Uno", null },
                    { 3, 2, "Palio", null },
                    { 4, 4, "Fusion", null },
                    { 5, 10, "C4 Lounge", null },
                    { 6, 5, "Civic lxr", null },
                    { 7, 11, "Dodge Ram", null },
                    { 8, 3, "Corvette C7 Stingray", null },
                    { 9, 12, "C63", null },
                    { 10, 1, "Gol", null },
                    { 11, 7, "Prius", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
