using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace cuentasPorPagarApi.Entities
{
    
    public class Usuario
    {
        [Key]
        public int usuarioId { get; set; }
        [MaxLength(25)]
        public string? Correo { get; set; }
        [MaxLength(16)]
        public string? contrasenha { get; set; }
    }
}
