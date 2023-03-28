using BE_Peliculas.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace BE_Peliculas.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:50)]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
        public List<PeliculasGeneros> PeliculasGeneros { get; set; }
    }
}
