using System.ComponentModel.DataAnnotations;

namespace BE_Peliculas.DTOs
{
    public class RatingDTO
    {
        public int PeliculaId { get; set; }
        [Range(1, 5)]
        public int Puntuacion { get; set; }
    }
}
