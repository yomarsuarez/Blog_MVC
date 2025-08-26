using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlogMVC.Models
{
    public class EntradaCrearViewModel
    {
        [Required(ErrorMessage = "El título es obligatorio.")]
        public required string Titulo { get; set; }
        [Required(ErrorMessage = "El título es obligatorio.")]
        public required string Cuerpo { get; set; }

        [DisplayName("Imagen Portada")]
        public IFormFile? ImagenPortada { get; set; }
        public string? ImagenPortadaIA { get; set; }
    }
}
