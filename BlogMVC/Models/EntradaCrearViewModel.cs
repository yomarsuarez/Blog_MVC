using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlogMVC.Models
{
    public class EntradaCrearViewModel
    {
        [Required(ErrorMessage = "The title is required.")]
        public required string Titulo { get; set; }
        [Required(ErrorMessage = "The title is required.")]
        public required string Cuerpo { get; set; }

        [DisplayName("Cover Image")]
        public IFormFile? ImagenPortada { get; set; }
        public string? ImagenPortadaIA { get; set; }
    }
}
