using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.DTOs
{
    public class GeneroCreacionDTO
    {
        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }
    }
}
