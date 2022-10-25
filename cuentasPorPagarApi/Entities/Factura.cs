using System.ComponentModel.DataAnnotations;

namespace cuentasPorPagarApi.Entities
{
    public class Factura
    {
        [Key]
        public int FacturaId { get; set; }
        public int TotalFactura { get; set; }
        public int ProveedorId { get; set; }

        public Proveedor? Proveedor { get; set; }
    }
}
