using System.ComponentModel.DataAnnotations;

namespace cuentasPorPagarApi.Entities
{
    public class MovimientosDeCuentas
    {
        [Key]
        public int PagoId { get; set; }
        public String? DescPago { get; set; }
        public int TotalPago { get; set; }
        public int FacturaId { get; set; }
        public Factura? Factura { get; set; }
    }
}
