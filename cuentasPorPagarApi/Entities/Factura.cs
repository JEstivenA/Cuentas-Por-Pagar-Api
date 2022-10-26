using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cuentasPorPagarApi.Entities
{
    public class Factura
    {
        [Key]
        public int FacturaId { get; set; }
        public int NoFactura { get; set; }
        public float TotalFactura { get; set; }
         
        public int ProveedorId { get; set; }

    }
}
