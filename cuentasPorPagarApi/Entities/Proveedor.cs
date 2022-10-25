using System.ComponentModel.DataAnnotations;

namespace cuentasPorPagarApi.Entities
{
    public class Proveedor
    {
        [Key]
        public int IdProveedor { get; set; }

        [StringLength(50)]
        public string? ProveedorName { get; set; }

        [StringLength(25)]
        public string? Email { get; set; }

        public int Telefono { get; set; }

        public ICollection<Factura> Facturas { get; set; }

        public Proveedor()
        {
            Facturas = new HashSet<Factura>();
        }

    }
}
