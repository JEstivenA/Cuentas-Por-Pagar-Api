using System.ComponentModel.DataAnnotations;

namespace cuentasPorPagarApi.Entities
{
    public class MovimientosDeCuentas
    {
        [Key]
        public int IdPago { get; set; }
        public int TotalPago { get; set; }
        public int DeudaRestante { get; set; }
        public int IdFactura { get; set; }
    }
}
