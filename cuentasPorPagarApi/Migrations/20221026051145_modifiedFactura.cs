using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cuentasPorPagarApi.Migrations
{
    public partial class modifiedFactura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "TotalFactura",
                table: "Facturas",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "NoFactura",
                table: "Facturas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoFactura",
                table: "Facturas");

            migrationBuilder.AlterColumn<int>(
                name: "TotalFactura",
                table: "Facturas",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
