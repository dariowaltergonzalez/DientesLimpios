using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace DientesLimpios.API.DTOs.Consultorios
{
    public class CrearConsultorioDTO
    {
        [Required]
        [StringLength(150)]
        public required string Nombre { get; set; }
    }
}
