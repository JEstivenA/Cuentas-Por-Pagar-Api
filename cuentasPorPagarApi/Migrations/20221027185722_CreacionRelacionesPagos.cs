using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cuentasPorPagarApi.Migrations
{
    public partial class CreacionRelacionesPagos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeudaRestante",
                table: "MovimientosDeCuentas");

            migrationBuilder.RenameColumn(
                name: "IdFactura",
                table: "MovimientosDeCuentas",
                newName: "FacturaId");

            migrationBuilder.AddColumn<string>(
                name: "DescPago",
                table: "MovimientosDeCuentas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MovimientosDeCuentas_FacturaId",
                table: "MovimientosDeCuentas",
                column: "FacturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovimientosDeCuentas_Facturas_FacturaId",
                table: "MovimientosDeCuentas",
                column: "FacturaId",
                principalTable: "Facturas",
                principalColumn: "FacturaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovimientosDeCuentas_Facturas_FacturaId",
                table: "MovimientosDeCuentas");

            migrationBuilder.DropIndex(
                name: "IX_MovimientosDeCuentas_FacturaId",
                table: "MovimientosDeCuentas");

            migrationBuilder.DropColumn(
                name: "DescPago",
                table: "MovimientosDeCuentas");

            migrationBuilder.RenameColumn(
                name: "FacturaId",
                table: "MovimientosDeCuentas",
                newName: "IdFactura");

            migrationBuilder.AddColumn<int>(
                name: "DeudaRestante",
                table: "MovimientosDeCuentas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
