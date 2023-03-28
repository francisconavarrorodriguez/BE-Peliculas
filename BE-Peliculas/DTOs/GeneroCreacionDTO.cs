using BE_Peliculas.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace BE_Peliculas.DTOs
{
    public class GeneroCreacionDTO
    {
        [Required]
        [StringLength(maximumLength: 50)]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
    }
}

