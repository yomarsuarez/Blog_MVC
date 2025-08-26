﻿using System.ComponentModel.DataAnnotations;

namespace BlogMVC.Models
{
    public class EntradaEditarViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El {0} es requerido")]
        public required string Titulo { get; set; }
        [Required(ErrorMessage = "El {0} es requerido")]
        public required string Cuerpo { get; set; }
        [Display(Name = "Portada")]
        public IFormFile? ImagenPortada { get; set; }
        public string? ImagenPortadaActual { get; set; }
        public bool ImagenRemovida { get; set; }
        public string? ImagenPortadaIA { get; set; }
    }
}
